using System;
using System.Collections.Generic;   
using System.Linq;
using System.Threading.Tasks;

namespace Models {

    public class Saldo {
        public int id { get; set; }
        public int ProdutoId { get; set; }
        public int AlmoxerifadoId { get; set; }
        public int Quantidade { get; set; }

        public static List<Saldo> Saldos { get; set; } = new List<Saldo>();

        public Saldo(int id, int produtoId, int almoxarifadoId, int quantidade) {
            this.id = id;
            this.ProdutoId = produtoId;
            this.AlmoxerifadoId = almoxarifadoId;
            this.Quantidade = quantidade;
        }

            public override string ToString() {
            return "Saldo{" +
            "id=" + id +
            ", idProduto=" + ProdutoId +
            ", AlmoxerifadoId=" + AlmoxerifadoId +
            ", Quantidade=" + Quantidade +
            '}';
            }

        public static void AlteraSaldo (Saldo saldo) 
        {
            Saldo saldoAntigo = BuscaSaldo(saldo.id);
            saldoAntigo.ProdutoId = saldo.ProdutoId;
            saldoAntigo.AlmoxerifadoId = saldo.AlmoxerifadoId;
            saldoAntigo.Quantidade = saldo.Quantidade;
        }

        public static Saldo BuscaSaldo (int id) 
        {
            Saldo? saldo = Saldos.Find(p => p.id == id);
            if (saldo == null) {
                throw new Exception("Saldo não encontrado");
            }

            return saldo;
        }

        public static void RemoveSaldo (int id) 
        {
            Saldo saldo = BuscaSaldo(id);
            Saldos.Remove(saldo);
        }

        public static void AdicionaSaldo (Saldo saldo) 
        {
            Saldos.Add(saldo);
        }      
    }
}