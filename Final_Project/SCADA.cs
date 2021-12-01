using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Final_Project
{
    public class SCADA
    {
        public List<Task_SCADA> Tasks = new List<Task_SCADA>();

        public List<Device> Devices = new List<Device>();

        public List<Device_Faceplate> Device_Faceplates = new List<Device_Faceplate>();

        public Main_Page main_Page;

        public PLC S71500;

        public SCADA()
        {

        }
        public void AddTask(Task_SCADA task)
        {
            task.Parent = this;
            Tasks.Add(task);
        }

        public void AddDevice(Device device)
        {
            device.Parent = this;
            device.Initialize_Addr();
            Devices.Add(device);
        }

        public void AddDevice_Faceplates(Device_Faceplate device_fpt, string name)
        {
            device_fpt.Text = name;
            Device_Faceplates.Add(device_fpt);
        }

        public void AddPlc(PLC Plc)
        {
            Plc.Parent = this;
            S71500 = Plc;
        }

        public void AddMain(Main_Page main_page)
        {
            main_page.Parent = this;
            main_Page = main_page;
        }

        public Task_SCADA FindTask(string name)
        {
            Task_SCADA task = null;
            for (int i = 0; i < Tasks.Count; i++)
            {
                task = Tasks[i];
                if (task.Name == name)
                {
                    return task;
                }
            }

            return null;
        }

        public void RunTask(string name)
        {
            Task_SCADA task = null;
            for (int i = 0; i < Tasks.Count; i++)
            {
                task = Tasks[i];
                if (task.Name == name)
                {
                    task.Engine();
                }
            }
        }

        public void RunDevice(string name)
        {
            Device device = null;
            for (int i = 0; i < Devices.Count; i++)
            {
                device = Devices[i];
                if (device.Name == name)
                {
                    device.Engine();
                }
            }
        }

        public void SleepTask(string name)
        {
            Task_SCADA task = null;
            for (int i = 0; i < Tasks.Count; i++)
            {
                task = Tasks[i];
                if (task.Name == name)
                {
                    task.Sleep();
                }
            }
        }

        public void ResumeTask(string name)
        {
            Task_SCADA task = null;
            for (int i = 0; i < Tasks.Count; i++)
            {
                task = Tasks[i];
                if (task.Name == name)
                {
                    task.Resume();
                }
            }
        }

        public void KillTask(string name)
        {
            Task_SCADA task = null;
            for (int i = 0; i < Tasks.Count; i++)
            {
                task = Tasks[i];
                if (task.Name == name)
                {
                    task.Kill();
                }
            }
        }

        public void write_PLC(string addr, object value)
        {
            try
            {
                S71500.thePLC.Write(addr, value);
            }
            catch
            {
                ;
            }
        }

        public void write_GlobalControlValue(string func, object value)
        {
            try
            {
                switch (func)
                {
                    case "StartAuto":
                        {
                            S71500.thePLC.Write(S71500.Addr_Start_Auto, value);
                            break;
                        }
                    case "StopAuto":
                        {
                            S71500.thePLC.Write(S71500.Addr_Stop_Auto, value);
                            break;
                        }
                    default: break;
                }
            }
            catch
            {
                ;
            }

        }
        public void ExportPdf(string strPdfPath, string strHeader)
        {
            FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntHead = new Font(bfntHead, 16, 1, BaseColor.GRAY);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
            document.Add(prgHeading);

            //Author
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntAuthor = new Font(btnAuthor, 8, 2, BaseColor.GRAY);
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new Chunk("Operator: DOAN NGO DUC PHUONG", fntAuthor));
            prgAuthor.Add(new Chunk("\nDate Time: " + DateTime.Now.ToString(), fntAuthor));
            document.Add(prgAuthor);

            //Add a line separation
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 0.0F)));
            document.Add(p);

            //Add line break
            document.Add(new Chunk("\n", fntHead));

            //Write Table
            for (int i = 0; i<Devices.Count; i++)
            {
                document.Add(new Chunk("\n", fntHead));

                Paragraph prgdevice = new Paragraph();
                BaseFont btndevice = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fntdevice = new Font(btndevice, 14, 2, BaseColor.GRAY);
                prgdevice.Alignment = Element.ALIGN_LEFT;
                prgdevice.Add(new Chunk(Devices[i].Name, fntdevice));
                document.Add(prgdevice);
                document.Add(new Chunk("\n", fntHead));

                DataTable data_table = Device_Faceplates[i].rpPage.table;
                PdfPTable table = new PdfPTable(data_table.Columns.Count);
                //Table Header
                BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fntColumnHeader = new Font(btnColumnHeader, 10, 1, BaseColor.WHITE);
                for (int j = 0; j<data_table.Columns.Count; j++)
                {
                    PdfPCell cell = new PdfPCell();
                    cell.BackgroundColor = BaseColor.GRAY;
                    cell.AddElement(new Chunk(data_table.Columns[j].ColumnName.ToUpper(), fntColumnHeader));
                    table.AddCell(cell);
                }
                //Table Data
                for (int j = 0; j<data_table.Rows.Count; j++)
                {
                    for (int k = 0; k<data_table.Columns.Count; k++)
                    {
                        table.AddCell(data_table.Rows[j][k].ToString());
                    }
                }
                document.Add(table);
            }
            document.Close();
            writer.Close();
            fs.Close();
        }
    }
}
