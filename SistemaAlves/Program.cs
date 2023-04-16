namespace SistemaAlves
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
        }
      

        public static void decNumber(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

           
            if (txt.Text.Contains(",") && (e.KeyChar == ','))
            {
                e.Handled = true;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {            
                    e.Handled = true;                
            }
        }


    }
}