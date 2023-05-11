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
               

                forca.ApresentarMensagem("As letras encontradas até agora são: " + forca.PalavraParcial);

              
            
        }

        private void VisualizarPalavra()
        {
            char palpite = Convert.ToChar(forca.currentWord);

            txtPalavraEscolhida.Text = forca.ObterPalavraSecreta();
            forca.JogadorAcertou(palpite);



        }






        private void Palpite(object sender, EventArgs e)
        {

        }











    }
}