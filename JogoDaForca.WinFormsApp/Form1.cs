namespace JogoDaForca.WinFormsApp
{
    public partial class Form1 : Form
    {

        private Forca forca;

        public Form1()
        {
            InitializeComponent();

            forca = new Forca();

            VisualizarPalavra();

        }

        private void ButtonClick(object sender, EventArgs e)
        {
            forca.currentWord += ((Button)sender).Text;

            

           

         
            txtCabeca.Visible = false;


                


        
                txtPalavra.Text = forca.currentWord;
                
             
                ((Button)sender).Enabled = false;
               

               

              
            
        }

        private void VisualizarPalavra()
        {
            

            txtPalavraEscolhida.Text = forca.ObterPalavraSecreta();
           



        }






        private void Palpite(object sender, EventArgs e)
        {

        }











    }
}