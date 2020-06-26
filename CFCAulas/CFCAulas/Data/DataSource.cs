using CFCAulas.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CFCAulas.Data
{
    public static class DataSource
    {
        public static List<Regla> Reglas = new List<Regla>();
        public static List<Infraccion> Infracciones = new List<Infraccion>();
        public static List<MedidaAdministrativa> MedidaAdministrativas = new List<MedidaAdministrativa>();
        public static List<Penalidad> Penalidades = new List<Penalidad>();
        public static List<Multiplicador> Multiplicadores = new List<Multiplicador>();

        static DataSource()
        {
            Infracciones = GenerarInfraciones();
            MedidaAdministrativas = GenerarMedidaAdministrativa();
            Penalidades = GenerarPenalidades();
            Multiplicadores = GenerarMultiplicadores();
            Reglas = GenerarRegras();

        }

        private static List<Regla> GenerarRegras()
        {
            return new List<Regla> {
            new Regla{ IdInfraccion=1, IdPenalidad=1 ,IdMultiplicador=1, IdMedidaAdministrativa=1, IdObservacion=1 },
            };
        }

        private static List<Infraccion> GenerarInfraciones()
        {
            return new List<Infraccion>
            {
                new Infraccion
                {
                  Id = 1, Nombre="Art, 253-A. Usar qualquer veiculo para, deliberadamente, interromper, restringir ou perturbar a circulacäo na via sem autorizaqäo do 6rgäo ou entidade de trånsito com circunscriqäo sobre ela"
                },
                 new Infraccion
                {
                  Id = 2, Nombre="Art. 165. Dirigir sob a influéncia de élcool ou de qualquer outra subståncia psicoativa que deter-mine dependéncia"
                },
                  new Infraccion
                {
                  Id = 3, Nombre="Art. 165-A. Recusar-se a ser submetido a teste, exame clinico, pericia ou outro procedimento que permita certificar influéncia de élcool ou outra subståncia psicoativa"
                },
                    new Infraccion
                {
                  Id = 4, Nombre="Art. 173. Disputar corrida"
                },
                     new Infraccion
                {
                  Id = 5, Nombre="Art. 174. Promover, na via, competiqäo, eventos organizados, exibicäo e demonstraqäo de pericia em manobra de veiculo, ou deles participar, como condutor, sem permissäo da autoridade de trånsito com circunscriqäo sobre a via"
                }, new Infraccion
                {
                  Id = 6, Nombre="Art. 175. Utilizar-se de vefculo para demonstrar ou exibir manobra perigosa, mediante arranca-da brusca, derrapagem ou frenagem com deslizamento ou arrastamento de pneus"
                }, new Infraccion
                {
                  Id = 7, Nombre="Art. 191. Forgar passagem entre veiculos que, transitando em sentidos opostos, estejam na iminéncia de passar um pelo outro ao realizar operagäo de ultrapassagem"
                },
            };
        }

        private static List<MedidaAdministrativa> GenerarMedidaAdministrativa()
        {
            return new List<MedidaAdministrativa> {
            new MedidaAdministrativa
             {
                Id = 1 , Nombre = "Remoção do veiculo",
             }, new MedidaAdministrativa
             {
                Id = 2 , Nombre = "Retenção do veiculo",
             },new MedidaAdministrativa
             {
                Id = 3 , Nombre = "Recolhimento da habilitação",
             },  new MedidaAdministrativa
             {
                Id = 4 , Nombre = "Recolhimento do documento de habilitação e retenção do veiculo",
             }, new MedidaAdministrativa
             {
                Id = 5 , Nombre = "Recolhimento do documento de habilitação e remoção do veiculo",
             },new MedidaAdministrativa
             {
                Id = 6 , Nombre = "Retenção do veiculo até a apresentação de condutor habilitado",
             },new MedidaAdministrativa
             {
                Id = 7 , Nombre = "Recolhimento do documento de habilitação e retenção do veiculo até a apresentação de condutor habilitado",
             },new MedidaAdministrativa
             {
                Id = 8 , Nombre = "Retenção do veiculo até que a irregularidade seja sanada",
             },new MedidaAdministrativa
             {
                Id = 9 , Nombre = "Retenção do veiculo até colocação do cinto pelo infrator",
             },new MedidaAdministrativa
             {
                Id = 10 , Nombre = "Retenção do veiculo para regularização.",
             },new MedidaAdministrativa
             {
                Id = 11 , Nombre = "Recolhimento do Certificado de Registro e do Certificado de licenciamento anual.",
             },new MedidaAdministrativa
             {
                Id = 12 , Nombre = "Recolhimento das placas e documentos.",
             },new MedidaAdministrativa
             {
                Id = 13 , Nombre = "Remoção da mercadoria e do material.",
             },new MedidaAdministrativa
             {
                Id = 14 , Nombre = "Retenção do veiculo para o transbordo.",
             },new MedidaAdministrativa
             {
                Id = 15 , Nombre = "Retenção do veiculo para regularização e apreensão das placas.",
             },new MedidaAdministrativa
             {
                Id = 16 , Nombre = "Remoção da bicicleta, mediante recibo para pagamento da multa.",
             },new MedidaAdministrativa
             {
                Id = 17 , Nombre = "Retenção do veiculo até a apresentação do documento.",
             },
            };
        }

        private static List<Penalidad> GenerarPenalidades()
        {
            return new List<Penalidad>
            {
                new Penalidad
                {
                    Id = 1,
                    Nombre = "Multa e suspensão do direito de dirigir por doze meses"
                }, new Penalidad
                {
                    Id = 2,
                    Nombre = "Multa e suspensão do direito de dirigir por doze meses"
                },new Penalidad
                {
                    Id = 3,
                    Nombre = "Multa e suspensão do direito de dirigir"
                },new Penalidad
                {
                    Id = 4,
                    Nombre = "Multa"
                },new Penalidad
                {
                    Id = 5,
                    Nombre = "Multa em (50%) cinquenta por cento do valor da infração de natureza leve"
                },
            };
        }

        private static List<Multiplicador> GenerarMultiplicadores()
        {
            return new List<Multiplicador>
            {
                new Multiplicador
                {
                    Id = 1,
                    Nombre = "x2"
                }, new Multiplicador
                {
                    Id = 2,
                    Nombre = "x3"
                }, new Multiplicador
                {
                    Id = 3,
                    Nombre = "x5"
                }, new Multiplicador
                {
                    Id = 4,
                    Nombre = "x10"
                }, new Multiplicador
                {
                    Id = 5,
                    Nombre = "x20"
                },new Multiplicador
                {
                    Id = 6,
                    Nombre = "x60"
                },
            };
        }
    }
}
