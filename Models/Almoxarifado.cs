using System;
using System.Collections.Generic;   
using System.Linq;
using System.Threading.Tasks;


namespace Models {
    public class Almoxarifado {
        public int id { get; set; }
        public string nome { get; set; }

        public static List<Almoxarifado> Almoxarifados { get; set; } = new List<Almoxarifado>();

        public Almoxarifado(int id, string nome) {
            this.id = id;
            this.nome = nome;
        }

        public override string ToString() {
            return "Almoxarifado{" +
                    "id=" + id +
                    ", nome='" + nome + '\'' +
                    '}';
        }

        public static void AlteraAlmoxarifado ( Almoxarifado almoxarifado) 
        {
            Almoxarifado almoxarifadoAntigo = BuscaAlmoxarifado(almoxarifado.id);
            almoxarifadoAntigo.nome = almoxarifado.nome;
        }

        public static Almoxarifado BuscaAlmoxarifado (int id) 
        {
            Almoxarifado? almoxarifado = Almoxarifados.Find(p => p.id == id);
            if (almoxarifado == null) {
                throw new Exception("Almoxarifado não encontrado");
            }

            return almoxarifado;
        }

        public static void RemoveAlmoxarifado (int id) 
        {
            Almoxarifado almoxarifado = BuscaAlmoxarifado(id);
            Almoxarifados.Remove(almoxarifado);
        }

        public static void AdicionaAlmoxarifado (Almoxarifado almoxarifado) 
        {
            Almoxarifados.Add(almoxarifado);
        }      
    }
}