using System;
using TestStack.White;
using TestStack.White.UIItems.WindowStripControls;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;
using System.Threading;
using System.Drawing;
using System.Drawing.Imaging;
using TestStack.White.Utility;
using System.Windows;
using System.Windows.Automation;

namespace TestingProjectForWhite

{

    public class UITest
    {
        public static String applicationPath = "C:\\Windows\\System32\\calc.exe";
        public static TestStack.White.UIItems.WindowItems.Window win;
        public static Application app;

        public void init()
        {
            app = Application.Launch(applicationPath);
            win = app.GetWindow("Calculator");
            win.WaitWhileBusy();
        }

        public bool isOpned()
        {
            return win.IsCurrentlyActive;
        }

        public Button getButtonByText(String button_text)
        {

            var buttons = extensionClass.GetMultipleWithWait(win,
                SearchCriteria.ByControlType(ControlType.Button));

            try
            {
                foreach (TestStack.White.UIItems.Button b in buttons)
                {
                    if (b.Enabled == true && b.Text.Equals(button_text))
                    {

                        try
                        {
                            Random rnd = new Random();
                            Utilities.takeScreenShot(b);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        return b;
                    }
                }

            }
            catch (Exception)
            {
                return null;
            }
            return null;
        }
        public void pressbuttonByText(String buttonText)
        {

            Retry.For(() => getButtonByText(buttonText).Click(), TimeSpan.FromSeconds(10));

        }

        public String getResultText()
        {
            TestStack.White.UIItems.Label display_edit = win.Get<TestStack.White.UIItems.Label>(TestStack.White.UIItems.Finders.SearchCriteria.ByAutomationId("150"));
            Utilities.takeScreenShot(win);
            return display_edit.Text;
        }

        public void changeCalcMode(String mode)
        {
            MenuBar menus = (MenuBar)win.Get(SearchCriteria
                .ByControlType(ControlType.MenuBar).AndByText("Application"));

            if (mode.Equals("Mortgage"))
            {
                Menu tobeSelected = menus.MenuItem("View", "Worksheets", "Mortgage");
                tobeSelected.Click();
            }
            else
            {
                Menu tobeSelected = menus.MenuItem("View", mode);
                tobeSelected.Click();
                win.WaitWhileBusy();
            }
        }


        public void selectListBox(String listboxName, String value)
        {
            win.WaitWhileBusy();


            var combo = extensionClass.GetMultipleWithWait(win, SearchCriteria.ByControlType(ControlType.ComboBox));
            foreach (ComboBox c in combo)
            {
                if (c.NameMatches(listboxName))
                {
                    c.Select(value);
                }

            }
        }

        public void enterTextByControlName(String textboxname, float textboxvalue)
        {
            var edit = win.GetMultiple(SearchCriteria.ByControlType(ControlType.Edit));


            foreach (TextBox t in edit)
            {
                if (t.NameMatches(textboxname))
                {
                    t.SetValue(textboxvalue);

                }
            }
        }


        public String getTextByControlName(String textboxname)
        {

            var edit = win.GetMultiple(SearchCriteria.ByControlType(ControlType.Edit));
            foreach (TextBox t in edit)
            {
                if (t.NameMatches(textboxname))
                {
                    win.WaitTill(delegate ()
                    {
                        Console.WriteLine("*****calling delegate****");
                        return t.Enabled;
                    });
                    return t.Text;
                }
            }
            return null;
        }


        public void tearDown()
        {

            changeCalcMode("Basic");
            changeCalcMode("Standard");
            win.Close();
        }
    }

    public static class extensionClass
    {
        public static T GetWithWait<T>(this Window window, SearchCriteria searchCriteria, int timeout = 30) where T : UIItem
        {
            T result = null;
            for (int i = 0; i < timeout; i++)
            {
                result = window.Get<T>(searchCriteria);
                if (result != null)
                {
                    return result;
                }
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
            return result;
        }


        public static IUIItem[] GetMultipleWithWait(this Window window, SearchCriteria searchCriteria, int timeout = 30)
        {

            for (int i = 0; i < timeout; i++)
            {
                var result = window.GetMultiple(searchCriteria);
                if (result.Length > 0)
                {
                    return (IUIItem[])result;
                }
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
            return null;
        }
    }

    public static class Utilities
    {

        public static void takeScreenShot(TestStack.White.UIItems.UIItem b)
        {

            try
            {
                String path;
                Rect bounds = b.Bounds;

                //getting values from Rect
                double h = bounds.Height;
                double w = bounds.Width;
                double x = bounds.X;
                double y = bounds.Y;
                //gettomg ramdom number, can change it to date time or somehting meaningful
                Random rndm = new Random();
                //this will generate randomnumber between 1 to 10,000
                int random = rndm.Next(10000);

                //getting current directory
                path = System.AppDomain.CurrentDomain.BaseDirectory;
                //replaceing the bin and debug as BaseDirectory will return this
                path = path.Replace("\\bin\\Debug", "");
                //creating path with random integer
                path = path + "results\\Screenshot_" + random + ".jpg";

                //logic for creating
                //creating equalent in System.Drawing
                //Source point
                System.Drawing.Point p = new System.Drawing.Point(Convert.ToInt32(x), Convert.ToInt32(y));
                //Destination point
                System.Drawing.Point p2 = new System.Drawing.Point(0, 0);

                //Creating Rectangle from Rect
                System.Drawing.Rectangle rect = new Rectangle(p.X, p.Y, Convert.ToInt32(w), Convert.ToInt32(h));

                //Creating bitmap with desired height and width
                Bitmap bitmap = new Bitmap(rect.Width, rect.Height);

                {
                    Graphics g = Graphics.FromImage(bitmap);
                    {
                        //Coping screen where automation element is present (p) to destnation point on the image (0,0)
                        g.CopyFromScreen(p, p2, rect.Size);
                    }
                    //Saving image
                    bitmap.Save(path, ImageFormat.Jpeg);
                }
            }
            catch (Exception e)

            {
                Console.WriteLine(e.Message);
            }

        }
    }
}


