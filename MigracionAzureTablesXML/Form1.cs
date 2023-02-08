namespace MigracionAzureTablesXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonMigrar_Click(object sender, EventArgs e)
        {
            //COMENZAMOS RECUPERANDO EL DOCUMENTO XML INCRUSTADO
            //PARA ELLO, DEBEMOS ACCEDER AL ASSEMBLY Y NOS 
            //DEVOLVERA UN Stream
            //EL DOCUMENTO TENDRA EL namespace DEL NOMBRE DE NUESTRO
            //PROYECTO Y EL NOMBRE DEL FICHERO
            //MigracionAzureTablesXML.alumnos.xml
            string assemblypath = "MigracionAzureTablesXML.alumnos.xml";
            Stream stream =
                this.GetType().Assembly.GetManifestResourceStream(assemblypath);

        }
    }
}