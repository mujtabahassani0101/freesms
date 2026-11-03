using System.Collections.Generic;
using FreeSms.Reporting;
using school_Af.Rpt;
using school_Af.Rpt.af;
using school_Af.Rpt.amar;
using school_Af.Rpt.karname;

public class asdd
{
	public static ReportClass a(string A_0)
	{
        // Catalog entries whose original classes/RPTs are absent from the EXE.
        // Use the intact recovered annual card, with explicit provenance in XML.
        if (A_0 == "CStdKarnameDorehByChart" || A_0 == "CStdKarnameDorehByChart_byBestStd_OneMark")
            return new ReportClass { ResourceName = A_0 + ".rpt" };
		int value = default;
		ReportClass result = default;
		while (true)
		{
			ReportClass reportClass = null;
			int num = 18;
			while (true)
			{
				switch (num)
				{
				case 18:
					if (A_0 != null)
					{
						num = 29;
						continue;
					}
					goto case 0;
				case 29:
					num = 35;
					continue;
				case 35:
					if (asdbg.d == null)
					{
						num = 41;
						continue;
					}
					goto case 4;
				case 41:
					asdbg.d = new Dictionary<string, int>(53)
					{
						{ "CrListDabirKham", 0 },
						{ "CrListDabir_1", 1 },
						{ "CrListstd_books10", 2 },
						{ "CrListstd_books14", 3 },
						{ "CrListstd_books18", 4 },
						{ "CrListStdBookMarks5", 5 },
						{ "CrAvgClassBooks_1", 6 },
						{ "CStdKarnameTajamoee", 7 },
						{ "CrAvgClassBooks_2", 8 },
						{ "CStdKarnameDoreh2", 9 },
						{ "CStdKarnameDoreh3", 10 },
						{ "CStdKarnameTajamoee2", 11 },
						{ "CrListstd_books10_class", 12 },
						{ "CrListstd_books18_class", 13 },
						{ "CrListBooksRengMark1", 14 },
						{ "CrListBooksRengMark2", 15 },
						{ "CrClslistOftRoshd", 16 },
						{ "CStdKarnameTajamoee2ByChart", 17 },
						{ "CrAmarGhaboliClass", 18 },
						{ "CrAmarGhaboliPaye", 19 },
						{ "CrListDabirKham16", 20 },
						{ "CrListDabirKham18", 21 },
						{ "CrListDabirKham20", 22 },
						{ "CrListDabirKhamByTchName", 23 },
						{ "CrListDabirKhamByTchNameAllBook18", 24 },
						{ "CrListstd_books18_class33", 25 },
						{ "CrListStdOftRoshdBooks", 26 },
						{ "CrListStdOftRoshdMoadel", 27 },
						{ "CrDabirAvgClassMark", 28 },
						{ "CStdKarnameTajamoee3ByChart", 29 },
						{ "CStdKarnameDoreh_byBestStd_OneMark", 30 },
						{ "CrListStdMoadelGroupByClass", 31 },
						{ "CrListStdMoadelGroupByPaye", 32 },
						{ "CrListStdMoadelGroupBySch", 33 },
						{ "CrStdMoadelMarkGroupByClass", 34 },
						{ "CrStdMoadelMarkGroupByPaye", 35 },
						{ "CrListstd_booksAlarm", 36 },
						{ "CrChapShaghe", 37 },
						{ "CrChapShagheHzeri", 38 },
						{ "CR_AF_StdKarnameDorehByChart_term1", 39 },
						{ "CR_AF_StdKarnameDorehByChart_term3", 40 },
						{ "CR_AF_StdKarnameDorehByChart_term1_land", 41 },
						{ "CR_AF_StdKarnameDorehByChart_term3_land", 42 },
						{ "CR_AF_StdKarnameFinal", 43 },
						{ "CrListstd_books21_class33", 44 },
						{ "CrListBooksRengMark_class", 45 },
						{ "CR_AF_ListFinal", 46 },
						{ "CR_AF_StdKarnameFinal_10_11", 47 },
						{ "CR_AF_StdKarnameFinal_12", 48 },
						{ "CR_AF_ListFinal9", 49 },
						{ "CR_AF_ListFinal10_11", 50 },
						{ "CR_AF_ListFinal12", 51 },
						{ "CR_AF_StdKarnameFinalAll", 52 }
					};
					num = 4;
					continue;
				case 4:
					num = 30;
					continue;
				case 30:
					if (asdbg.d.TryGetValue(A_0, out value))
					{
						num = 17;
						continue;
					}
					goto case 0;
				case 33:
					num = 6;
					continue;
				case 17:
					num = 3;
					continue;
				case 3:
					switch (value)
					{
					case 36:
						reportClass = new CrListstd_booksAlarm();
						num = 7;
						break;
					case 28:
						reportClass = new CrDabirAvgClassMark();
						num = 47;
						break;
					case 7:
						reportClass = new CStdKarnameTajamoee();
						num = 8;
						break;
					case 43:
						reportClass = new CR_AF_StdKarnameFinal();
						num = 16;
						break;
					case 2:
						reportClass = new CrListstd_books10();
						num = 42;
						break;
					case 35:
						reportClass = new CrStdMoadelMarkGroupByPaye();
						num = 52;
						break;
					case 48:
						reportClass = new CR_AF_StdKarnameFinal_12();
						num = 25;
						break;
					case 29:
						reportClass = new CStdKarnameTajamoee3ByChart();
						num = 61;
						break;
					case 9:
						reportClass = new CStdKarnameDoreh2();
						num = 34;
						break;
					case 46:
						reportClass = new CR_AF_ListFinal();
						num = 55;
						break;
					case 52:
						reportClass = new CR_AF_StdKarnameFinalAll();
						num = 46;
						break;
					case 19:
						reportClass = new CrAmarGhaboliPaye();
						num = 38;
						break;
					case 6:
						reportClass = new CrAvgClassBooks_1();
						num = 19;
						break;
					case 4:
						reportClass = new CrListstd_books18();
						num = 0;
						break;
					case 10:
						reportClass = new CStdKarnameDoreh3();
						if (true)
						{
						}
						num = 2;
						break;
					case 47:
						reportClass = new CR_AF_StdKarnameFinal_10_11();
						num = 63;
						break;
					case 40:
						reportClass = new CR_AF_StdKarnameDorehByChart_term3();
						num = 40;
						break;
					case 18:
						reportClass = new CrAmarGhaboliClass();
						num = 49;
						break;
					case 17:
						reportClass = new CStdKarnameTajamoee2ByChart();
						num = 21;
						break;
					case 32:
						reportClass = new CrListStdMoadelGroupByPaye();
						num = 50;
						break;
					case 13:
						reportClass = new CrListstd_books18_class();
						num = 15;
						break;
					case 8:
						reportClass = new CrAvgClassBooks_2();
						num = 39;
						break;
					case 42:
						reportClass = new CR_AF_StdKarnameDorehByChart_term3_land();
						num = 9;
						break;
					case 12:
						reportClass = new CrListstd_books10_class();
						num = 51;
						break;
					case 11:
						reportClass = new CStdKarnameTajamoee2();
						num = 1;
						break;
					case 14:
						reportClass = new CrListBooksRengMark1();
						num = 23;
						break;
					case 26:
						reportClass = new CrListStdOftRoshdBooks();
						num = 12;
						break;
					case 24:
						reportClass = new CrListDabirKhamByTchNameAllBook18();
						num = 53;
						break;
					case 20:
						reportClass = new CrListDabirKham16();
						num = 45;
						break;
					case 39:
						reportClass = new CR_AF_StdKarnameDorehByChart_term1();
						num = 60;
						break;
					case 21:
						reportClass = new CrListDabirKham18();
						num = 28;
						break;
					case 49:
						reportClass = new CR_AF_ListFinal9();
						num = 22;
						break;
					case 1:
						reportClass = new CrListDabir_1();
						num = 43;
						break;
					case 50:
						reportClass = new CR_AF_ListFinal10_11();
						num = 54;
						break;
					case 15:
						reportClass = new CrListBooksRengMark2();
						num = 58;
						break;
					case 3:
						reportClass = new CrListstd_books14();
						num = 5;
						break;
					case 41:
						reportClass = new CR_AF_StdKarnameDorehByChart_term1_land();
						num = 56;
						break;
					case 5:
						reportClass = new CrListStdBookMarks5();
						num = 62;
						break;
					case 34:
						reportClass = new CrStdMoadelMarkGroupByClass();
						num = 36;
						break;
					case 22:
						reportClass = new CrListDabirKham20();
						num = 24;
						break;
					case 45:
						reportClass = new CrListBooksRengMark_class();
						num = 14;
						break;
					case 38:
						reportClass = new CrChapShagheHzeri();
						num = 11;
						break;
					case 44:
						reportClass = new CrListstd_books21_class33();
						num = 57;
						break;
					case 51:
						reportClass = new CR_AF_ListFinal12();
						num = 59;
						break;
					case 0:
						reportClass = new CrListDabirKham();
						num = 27;
						break;
					case 31:
						reportClass = new CrListStdMoadelGroupByClass();
						num = 32;
						break;
					case 23:
						reportClass = new CrListDabirKhamByTchName();
						num = 20;
						break;
					case 30:
						reportClass = new CStdKarnameDoreh_byBestStd_OneMark();
						num = 13;
						break;
					case 16:
						reportClass = new CrClslistOftRoshd();
						num = 37;
						break;
					case 37:
						reportClass = new CrChapShaghe();
						num = 44;
						break;
					case 27:
						reportClass = new CrListStdOftRoshdMoadel();
						num = 10;
						break;
					case 25:
						reportClass = new CrListstd_books18_class33();
						num = 26;
						break;
					case 33:
						reportClass = new CrListStdMoadelGroupBySch();
						num = 31;
						break;
					default:
						num = 33;
						break;
					}
					continue;
				case 0:
				case 1:
				case 2:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
				case 10:
				case 11:
				case 12:
				case 13:
				case 14:
				case 15:
				case 16:
				case 19:
				case 20:
				case 21:
				case 22:
				case 23:
				case 24:
				case 25:
				case 26:
				case 27:
				case 28:
				case 31:
				case 32:
				case 34:
				case 36:
				case 37:
				case 38:
				case 39:
				case 40:
				case 42:
				case 43:
				case 44:
				case 45:
				case 46:
				case 47:
				case 49:
				case 50:
				case 51:
				case 52:
				case 53:
				case 54:
				case 55:
				case 56:
				case 57:
				case 58:
				case 59:
				case 60:
				case 61:
				case 62:
				case 63:
					result = reportClass;
					num = 48;
					continue;
				case 48:
					return result;
				}
				break;
			}
		}
	}
}
