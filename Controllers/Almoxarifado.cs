using System;
using System.Collections.Generic;
using System.Linq;

    namespace Controllers {

        public class Almoxarifado {
            public static void AdicionaAlmoxarifado (int id, string nome) 
            {
                try {  
                    if (!checkIfExists(id)) {
                    Models.Almoxarifado.AdicionaAlmoxarifado(new Models.Almoxarifado(id, nome));
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
                    Models.Almoxarifado.BuscaAlmoxarifado(id);
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            public static void AlteraAlmoxarifado (int id, string nome) 
            {
                Models.Almoxarifado.AlteraAlmoxarifado(new Models.Almoxarifado(id, nome));
            }
    
            public static void RemoveAlmoxarifado (int id) 
            {
                Models.Almoxarifado.RemoveAlmoxarifado(id);
            }

            public static Models.Almoxarifado BuscaAlmoxarifado (int id) 
            {
                return Models.Almoxarifado.BuscaAlmoxarifado(id);
            }
    
            public static List<Models.Almoxarifado> ListaAlmoxarifados () 
            {
                return Models.Almoxarifado.Almoxarifados;
            }
        }
    }