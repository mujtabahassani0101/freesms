"""Inventory recovered click actions, retaining existing scenario evidence/status."""
import json
import re
from pathlib import Path

root = Path(__file__).resolve().parent.parent
path = root / 'validation/functional/action-inventory.json'
previous = json.loads(path.read_text()) if path.exists() else {'actions': []}
known = {action['id']: action for action in previous['actions']}
forms = json.loads((root / 'native/assets/forms.json').read_text())
actions = []
for form in forms:
    source = (root / 'dotnet/FreeSms.Original.Windows' / (form['class'] + '.cs')).read_text()
    # Fail if extraction silently omits a real click handler, including C# @identifiers.
    for variable, handler in re.findall(r'(?:this\.)?(\w+)\.Click\s*\+=\s*(@?\w+)\s*;', source):
        control = next((control for control in form['controls'] if control['variable'] == variable), None)
        if control is None or control.get('click') != handler.lstrip('@'):
            raise ValueError(f"Missing/mismatched click binding: {form['class']}.{variable} -> {handler}")
    for control in form['controls']:
        if 'click' not in control:
            continue
        action_id = form['class'] + '.' + control['variable']
        old = known.get(action_id, {})
        actions.append({'id': action_id, 'form_class': form['class'], 'form': form['name'],
                        'form_caption': form.get('text'), 'control': control.get('name'),
                        'caption': control.get('text'), 'handler': control['click'],
                        'targets': form.get('actions', {}).get(control['click'], []),
                        'status': old.get('status', 'unverified'), 'evidence': old.get('evidence', [])})
result = {'scope': previous.get('scope', 'Every recovered click action; workflow coverage requires persisted effects and explicit evidence.'),
          'forms': len(forms), 'controls': sum(len(form['controls']) for form in forms),
          'click_actions': len(actions), 'actions': actions}
path.parent.mkdir(parents=True, exist_ok=True)
path.write_text(json.dumps(result, ensure_ascii=False, indent=2) + '\n')
print(f"{result['forms']} forms, {result['controls']} controls, {len(actions)} click actions; source bindings verified")
