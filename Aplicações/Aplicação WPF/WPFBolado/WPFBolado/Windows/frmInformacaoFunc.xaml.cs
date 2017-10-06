using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFBolado.BLL;
using WPFBolado.DTO;

namespace WPFBolado.Windows
{
    
    public partial class frmInformacaoFunc : Window
    {
        LoginBLL lBLL = new LoginBLL();
        LoginDTO lDTO = new LoginDTO();
        FuncionarioBLL fBLL = new FuncionarioBLL();

        public frmInformacaoFunc()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lDTO.Usuario = frmLogin.user;
            lDTO.Senha = frmLogin.senha;
            lDTO.Id = lBLL.SelecionarIdporNome(lDTO);

            dtgFunc.DataContext = fBLL.SelecionarTudoPorId(lDTO);
        }
    }
}
