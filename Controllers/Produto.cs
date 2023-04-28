using System;
using System.Collections.Generic;
using System.Linq;

    namespace Controllers {

        public class Produto {
            public static void AdicionaProduto (int id, string nome, float preco) 
            {
                try {   
                    if (!checkIfExists(id)) {
                        Models.Produto.AdicionaProduto(new Models.Produto(id, nome, preco));
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
                    Models.Produto.BuscaProduto(id);
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            public static void AlteraProduto (int id, string nome, float preco) 
            {
                Models.Produto.AlteraProduto(new Models.Produto(id, nome, preco));
            }
    
            public static void RemoveProduto (int id) 
            {
                Models.Produto.RemoveProduto(id);
            }

            public static Models.Produto BuscaProduto (int id) 
            {
                return Models.Produto.BuscaProduto(id);
            }
    
            public static List<Models.Produto> ListaProdutos () 
            {
                return Models.Produto.Produtos;
            }
        }
    }