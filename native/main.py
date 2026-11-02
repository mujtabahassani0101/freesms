import argparse
import sys
from PySide6.QtCore import Qt
from PySide6.QtGui import QFont, QFontDatabase
from PySide6.QtWidgets import QApplication, QMessageBox, QProgressDialog

from layout import ASSETS, BY_NAME, LegacyForm


def main():
    parser = argparse.ArgumentParser(description='Free SMS — مدیریت مکتب بدون کلید سخت‌افزاری')
    parser.add_argument('--form', default='frmMain')
    parser.add_argument('--screenshot')
    parser.add_argument('--preview', action='store_true')
    args = parser.parse_args()
    app = QApplication(sys.argv[:1])
    app.setStyle('Fusion')
    app.setLayoutDirection(Qt.RightToLeft)
    QFontDatabase.addApplicationFont(str(ASSETS / 'BNAZANIN.TTF'))
    app.setFont(QFont('B Nazanin', 12))
    runtime = None
    if not args.preview:
        from backend.database import Database
        from backend.migrations import migrate
        from runtime import ApplicationRuntime
        progress = QProgressDialog('آماده‌سازی بانک اطلاعاتی...', '', 0, 0)
        progress.setWindowTitle('مدیریار')
        progress.setCancelButton(None)
        progress.show()
        app.processEvents()
        try:
            database = Database().ensure_database()
            migrate(database, progress.setLabelText)
            runtime = ApplicationRuntime(database)
        except Exception as error:
            progress.close()
            QMessageBox.critical(None, 'برنامه باز نشد', str(error))
            return 1
        progress.close()
    form = LegacyForm(BY_NAME[args.form], preview=args.preview, runtime=runtime)
    form.show()
    if args.screenshot:
        app.processEvents()
        form.grab().save(args.screenshot)
        return 0
    return app.exec()


if __name__ == '__main__':
    sys.exit(main())
