﻿using System;
using System.Collections.Generic;
using System.IO;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using X14 = DocumentFormat.OpenXml.Office2010.Excel;
using X15 = DocumentFormat.OpenXml.Office2013.Excel;

namespace Car_shop_Library
{
    public class Excell
    {
        public Excell() { }

        public void CreatePartsForExcel(SpreadsheetDocument document, SerializableBindingList<Veicolo> data)
        {
            SheetData partSheetData = GenerateSheetdataForDetails(data);

            WorkbookPart workbookPart1 = document.AddWorkbookPart();
            GenerateWorkbookPartContent(workbookPart1);

            WorkbookStylesPart workbookStylesPart1 = workbookPart1.AddNewPart<WorkbookStylesPart>("rId3");
            GenerateWorkbookStylesPartContent(workbookStylesPart1);

            WorksheetPart worksheetPart1 = workbookPart1.AddNewPart<WorksheetPart>("rId1");
            GenerateWorksheetPartContent(worksheetPart1, partSheetData);
        }

        private void GenerateWorkbookPartContent(WorkbookPart workbookPart1)
        {
            Workbook workbook1 = new Workbook();
            Sheets sheets1 = new Sheets();
            Sheet sheet1 = new Sheet() { Name = "Sheet1", SheetId = (UInt32Value)1U, Id = "rId1" };
            sheets1.Append(sheet1);
            workbook1.Append(sheets1);
            workbookPart1.Workbook = workbook1;
        }

        private void GenerateWorksheetPartContent(WorksheetPart worksheetPart1, SheetData sheetData1)
        {
            Worksheet worksheet1 = new Worksheet() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "x14ac" } };
            worksheet1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            worksheet1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            worksheet1.AddNamespaceDeclaration("x14ac", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac");
            SheetDimension sheetDimension1 = new SheetDimension() { Reference = "A1" };

            SheetViews sheetViews1 = new SheetViews();

            SheetView sheetView1 = new SheetView() { TabSelected = true, WorkbookViewId = (UInt32Value)0U };
            Selection selection1 = new Selection() { ActiveCell = "A1", SequenceOfReferences = new ListValue<StringValue>() { InnerText = "A1" } };

            sheetView1.Append(selection1);

            sheetViews1.Append(sheetView1);
            SheetFormatProperties sheetFormatProperties1 = new SheetFormatProperties() { DefaultRowHeight = 15D, DyDescent = 0.25D };

            PageMargins pageMargins1 = new PageMargins() { Left = 0.7D, Right = 0.7D, Top = 0.75D, Bottom = 0.75D, Header = 0.3D, Footer = 0.3D };
            worksheet1.Append(sheetDimension1);
            worksheet1.Append(sheetViews1);
            worksheet1.Append(sheetFormatProperties1);
            worksheet1.Append(sheetData1);
            worksheet1.Append(pageMargins1);
            worksheetPart1.Worksheet = worksheet1;
        }

        private void GenerateWorkbookStylesPartContent(WorkbookStylesPart workbookStylesPart1)
        {
            Stylesheet stylesheet1 = new Stylesheet() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "x14ac" } };
            stylesheet1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            stylesheet1.AddNamespaceDeclaration("x14ac", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac");


            Fonts fonts = new Fonts() { Count = (UInt32Value)2U, KnownFonts = true };
            Fills fills = new Fills() { Count = (UInt32Value)2U };
            PatternValues[] pv = { PatternValues.None, PatternValues.Gray125 };
            Borders borders = new Borders() { Count = (UInt32Value)2U };
            BorderStyleValues[] bsv = { BorderStyleValues.None, BorderStyleValues.Thin };

            for (int i = 0; i < 2; i++)
            {
                Font font = new Font();
                FontSize fontSize = new FontSize() { Val = 11D };
                Color color = new Color() { Theme = (UInt32Value)1U };
                FontName fontName = new FontName() { Val = "Calibri" };
                FontFamilyNumbering fontFamilyNumbering = new FontFamilyNumbering() { Val = 2 };
                FontScheme fontScheme = new FontScheme() { Val = FontSchemeValues.Minor };

                font.Append(fontSize);
                font.Append(color);
                font.Append(fontName);
                font.Append(fontFamilyNumbering);
                font.Append(fontScheme);

                fonts.Append(font);


                Fill fill = new Fill();
                PatternFill patternFill1 = new PatternFill() { PatternType = pv[i] };

                fill.Append(patternFill1);
                fills.Append(fill);


                Border border = new Border();
                LeftBorder leftBorder = new LeftBorder() { Style = bsv[i] };
                RightBorder rightBorder = new RightBorder() { Style = bsv[i] };
                TopBorder topBorder = new TopBorder() { Style = bsv[i] };
                BottomBorder bottomBorder = new BottomBorder() { Style = bsv[i] };
                DiagonalBorder diagonalBorder = new DiagonalBorder();

                if (i == 1)
                {
                    Color color2 = new Color() { Indexed = (UInt32Value)64U };
                    Color color3 = new Color() { Indexed = (UInt32Value)64U };
                    Color color4 = new Color() { Indexed = (UInt32Value)64U };
                    Color color5 = new Color() { Indexed = (UInt32Value)64U };
                    leftBorder.Append(color2);
                    rightBorder.Append(color3);
                    topBorder.Append(color4);
                    bottomBorder.Append(color5);
                }

                border.Append(leftBorder);
                border.Append(rightBorder);
                border.Append(topBorder);
                border.Append(bottomBorder);
                border.Append(diagonalBorder);

                borders.Append(border);
            }

            CellStyleFormats cellStyleFormats1 = new CellStyleFormats() { Count = (UInt32Value)1U };
            CellFormat cellFormat1 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U };

            cellStyleFormats1.Append(cellFormat1);

            CellFormats cellFormats1 = new CellFormats() { Count = (UInt32Value)3U };
            CellFormat cellFormat2 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U };
            CellFormat cellFormat3 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)1U, FormatId = (UInt32Value)0U, ApplyBorder = true };
            CellFormat cellFormat4 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)1U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)1U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true };

            cellFormats1.Append(cellFormat2);
            cellFormats1.Append(cellFormat3);
            cellFormats1.Append(cellFormat4);

            CellStyles cellStyles1 = new CellStyles() { Count = (UInt32Value)1U };
            CellStyle cellStyle1 = new CellStyle() { Name = "Normal", FormatId = (UInt32Value)0U, BuiltinId = (UInt32Value)0U };

            cellStyles1.Append(cellStyle1);
            DifferentialFormats differentialFormats1 = new DifferentialFormats() { Count = (UInt32Value)0U };
            TableStyles tableStyles1 = new TableStyles() { Count = (UInt32Value)0U, DefaultTableStyle = "TableStyleMedium2", DefaultPivotStyle = "PivotStyleLight16" };

            StylesheetExtensionList stylesheetExtensionList1 = new StylesheetExtensionList();

            StylesheetExtension stylesheetExtension1 = new StylesheetExtension() { Uri = "{EB79DEF2-80B8-43e5-95BD-54CBDDF9020C}" };
            stylesheetExtension1.AddNamespaceDeclaration("x14", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/main");
            X14.SlicerStyles slicerStyles1 = new X14.SlicerStyles() { DefaultSlicerStyle = "SlicerStyleLight1" };

            stylesheetExtension1.Append(slicerStyles1);

            StylesheetExtension stylesheetExtension2 = new StylesheetExtension() { Uri = "{9260A510-F301-46a8-8635-F512D64BE5F5}" };
            stylesheetExtension2.AddNamespaceDeclaration("x15", "http://schemas.microsoft.com/office/spreadsheetml/2010/11/main");
            X15.TimelineStyles timelineStyles1 = new X15.TimelineStyles() { DefaultTimelineStyle = "TimeSlicerStyleLight1" };

            stylesheetExtension2.Append(timelineStyles1);

            stylesheetExtensionList1.Append(stylesheetExtension1);
            stylesheetExtensionList1.Append(stylesheetExtension2);

            stylesheet1.Append(fonts);
            stylesheet1.Append(fills);
            stylesheet1.Append(borders);
            stylesheet1.Append(cellStyleFormats1);
            stylesheet1.Append(cellFormats1);
            stylesheet1.Append(cellStyles1);
            stylesheet1.Append(differentialFormats1);
            stylesheet1.Append(tableStyles1);
            stylesheet1.Append(stylesheetExtensionList1);

            workbookStylesPart1.Stylesheet = stylesheet1;
        }

        private SheetData GenerateSheetdataForDetails(SerializableBindingList<Veicolo> data)
        {
            SheetData sheetData1 = new SheetData();
            sheetData1.Append(CreateHeaderRowForExcel());

            foreach (Veicolo testmodel in data)
            {
                Row partsRows = GenerateRowForChildPartDetail(testmodel);
                sheetData1.Append(partsRows);
            }
            return sheetData1;
        }

        private Row CreateHeaderRowForExcel()
        {
            Row workRow = new Row();
            workRow.Append(CreateCell("Marca", 2U));
            workRow.Append(CreateCell("Modello", 2U));
            workRow.Append(CreateCell("Colore", 2U));
            workRow.Append(CreateCell("Cilindrata", 2U));
            workRow.Append(CreateCell("Potenza", 2U));
            workRow.Append(CreateCell("Matricolazione", 2U));
            workRow.Append(CreateCell("Usato", 2U));
            workRow.Append(CreateCell("Km Zero", 2U));
            workRow.Append(CreateCell("Km Fatti", 2U));
            workRow.Append(CreateCell("Prezzo", 2U));
            workRow.Append(CreateCell("numero Airbag/Marca sella", 2U));
            return workRow;
        }

        private Row GenerateRowForChildPartDetail(Veicolo testmodel)
        {
            Row tRow = new Row();
            string usato = "No";
            string kmZero = "No";
             
            tRow.Append(CreateCell(testmodel.Marca));
            tRow.Append(CreateCell(testmodel.Modello));
            tRow.Append(CreateCell(testmodel.Colore));
            tRow.Append(CreateCell(testmodel.Cilindrata.ToString()));
            tRow.Append(CreateCell(testmodel.Potenza.ToString()+ " kw"));
            tRow.Append(CreateCell(testmodel.Matricolazione.ToShortDateString()));
            if (testmodel.Usato) usato = "Si";
            tRow.Append(CreateCell(usato));
            if (testmodel.Usato) kmZero = "Si";
            tRow.Append(CreateCell(kmZero));
            tRow.Append(CreateCell(testmodel.KmFatti.ToString()));
            tRow.Append(CreateCell(testmodel.Prezzo.ToString()));
            if(testmodel is Auto) tRow.Append(CreateCell((testmodel as Auto).NumAirbag.ToString()));
            else tRow.Append(CreateCell((testmodel as Moto).Sella));

            return tRow;
        }

        private Cell CreateCell(string text)
        {
            Cell cell = new Cell();
            cell.StyleIndex = 1U;
            cell.DataType = ResolveCellDataTypeOnValue(text);
            cell.CellValue = new CellValue(text);
            return cell;
        }

        private Cell CreateCell(string text, uint styleIndex)
        {
            Cell cell = new Cell();
            cell.StyleIndex = styleIndex;
            cell.DataType = ResolveCellDataTypeOnValue(text);
            cell.CellValue = new CellValue(text);
            return cell;
        }

        private EnumValue<CellValues> ResolveCellDataTypeOnValue(string text)
        {
            int intVal;
            double doubleVal;
            if (int.TryParse(text, out intVal) || double.TryParse(text, out doubleVal))
            {
                return CellValues.Number;
            }
            else
            {
                return CellValues.String;
            }
        }
    }

    public class TestModel
    {
        public int TestId { get; set; }
        public string TestName { get; set; }
        public string TestDesc { get; set; }
        public DateTime TestDate { get; set; }
    }

    public class TestModelList
    {
        public List<TestModel> testData { get; set; }
    }
}