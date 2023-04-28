using System;
using System.Collections.Generic;
using System.Linq;

    namespace Controllers {

        public class Saldo {
            public static void AdicionaSaldo (int id, int produtoId, int almoxarifadoId, int quantidade) 
            {
                try {  
                    if (!checkIfExists(id)) {
                    Models.Saldo.AdicionaSaldo(new Models.Saldo(id, produtoId, almoxarifadoId, quantidade));
                } else {
                        throw new Exception("Id já existente");
                    }
                } catch (Exception err) {
                    throw err;
                }
            }

            private static bool checkIfExists(int id)
            {
                try
                {
                    Models.Saldo.BuscaSaldo(id);
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            public static void AlteraSaldo (int id, int produtoId, int almoxarifadoId, int quantidade) 
            {
                Models.Saldo.AlteraSaldo(new Models.Saldo(id, produtoId, almoxarifadoId, quantidade));
            }
    
            public static void RemoveSaldo (int id) 
            {
                Models.Saldo.RemoveSaldo(id);
            }

            public static Models.Saldo BuscaSaldo (int id) 
            {
                return Models.Saldo.BuscaSaldo(id);
            }
    
            public static List<Models.Saldo> ListaSaldos () 
            {
                return Models.Saldo.Saldos;
            }
        }
    }