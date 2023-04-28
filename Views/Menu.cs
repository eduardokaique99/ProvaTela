using System;
using System.Windows.Forms;

namespace Views {

    public class Menu {

        public static void Menus() {

            Form menu = new Form();
            menu.Text = "Menu";
            menu.Size = new System.Drawing.Size(250, 270);
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.FormBorderStyle = FormBorderStyle.FixedSingle;
            menu.MaximizeBox = false;
            menu.MinimizeBox = false;

            Button btnProduto = new Button();
            btnProduto.Text = "PRODUTOS";
            btnProduto.AutoSize = true;
            btnProduto.Location = new System.Drawing.Point(80, 25);
            btnProduto.Click += (sender, e) => {
                Produtos.ListarProduto();
            };

            Button btnAlmox = new Button();
            btnAlmox.Text = "ALMOXARIFADO";
            btnAlmox.AutoSize = true;
            btnAlmox.Location = new System.Drawing.Point(68, 75);
            btnAlmox.Click += (sender, e) => {
                Almoxarifados.ListarAlmox();
            };

            Button btnSaldo = new Button();
            btnSaldo.Text = "SALDO";
            btnSaldo.AutoSize = true;
            btnSaldo.Location = new System.Drawing.Point(80, 125);
            btnSaldo.Click += (sender, e) => {
                Saldos.ListarSaldo();
            };
            
            Button sair = new Button();
            sair.Text = "SAIR";
            sair.AutoSize = true;
            sair.Location = new System.Drawing.Point( 80 , 175);
            sair.Click += (sender, e) => {
                menu.Close();
            };

            menu.Controls.Add(btnProduto);
            menu.Controls.Add(btnAlmox);
            menu.Controls.Add(btnSaldo);
            menu.Controls.Add(sair);
            menu.ShowDialog();
    }
    }
}