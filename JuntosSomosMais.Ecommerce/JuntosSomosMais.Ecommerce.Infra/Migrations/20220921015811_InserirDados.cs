using Microsoft.EntityFrameworkCore.Migrations;

namespace JuntosSomosMais.Ecommerce.Infra.Migrations
{
    public partial class InserirDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO ENDERECOS VALUES(1,'TRAVESSA ATLANTIDA', 'REMEDIOS', '788', '68927-060', '1 ANDAR', 'AO LADO DA PREFEITURA', 'SANTANA', 'AP', 'BRASIL'); ");
            migrationBuilder.Sql("INSERT INTO ENDERECOS VALUES(2,'PROFESSOR DOUTOR MAX KAUFMANN','JARDIM COLONIAL','453','13087-690','TERREO','PERTO DA PADARIA','CAMPINAS','SP','BRASIL'); ");
            migrationBuilder.Sql("INSERT INTO ENDERECOS VALUES(3,'PARANAGUA', 'MATINHA', '943', '68030-055', 'ULTIMO ANDAR', 'AZULEJO ROSA', 'SANTAREM', 'PA', 'BRASIL'); ");
            migrationBuilder.Sql("INSERT INTO ENDERECOS VALUES(4,'DUILIO SPIANDORIN', 'JARDIM PACAEMBU', '575', '13218-143', 'TERREO', 'CASA AZUL', 'JUNDIAI', 'SP', 'BRASIL'); ");
            migrationBuilder.Sql("INSERT INTO ENDERECOS VALUES(5,'MARIA ISABEL MAIA PIO DOS SANTOS', 'SERRARIA', '949', '57046-545', 'SEGUNDO ANDAR', 'AO LADO DA PADARIA', 'MACEIO', 'AL', 'BRASIL'); ");
            migrationBuilder.Sql("INSERT INTO ENDERECOS VALUES(6,'ROMAO GOMES DE MATOS', 'PARQUE ALVORADA', '362', '79823-281', 'CASA', 'PRIMEIRA CASA DA ESQUINA', 'DOURADOS', 'MS', 'BRASIL'); ");
            migrationBuilder.Sql("INSERT INTO ENDERECOS VALUES(7,'RUA DOIS', 'MORADA DO OURO - SETOR NOROESTE', '538', '78053-148', 'APTO 362', 'AO LADO DO ELEVADOR', 'CUIABA', 'MT', 'BRASIL'); ");
            migrationBuilder.Sql("INSERT INTO ENDERECOS VALUES(8,'RUA PORTO ALEGRE', 'LAERCIO CABELINE', '778', '68627-468', 'APTO 04', 'PORTA AZUL', 'PARAGOMINAS', 'PA', 'BRASIL'); ");
            migrationBuilder.Sql("INSERT INTO ENDERECOS VALUES(9,'QUADRA QR 408 CONJUNTO 13', 'SAMAMBAIA NORTE', '653', '72318-314', 'CASA', 'AO LADO DA LANCHONETE BOOP', 'BRASILIA', 'DF', 'BRASIL'); ");
            migrationBuilder.Sql("INSERT INTO ENDERECOS VALUES(10,'SANTA INES', 'CENTENARIO', '305', '69312-515', 'QUINTO ANDAR', 'APTO 512', 'BOA VISTA', 'RR', 'BRASIL'); ");
            migrationBuilder.Sql("INSERT INTO ENDERECOS VALUES(11,'VINTE E UM DE ABRIL', 'JARDIM IPANEMA', '862', '85862-309', 'CASA ROXA', 'EM FRENTE A BIBLIOTECA', 'FOZ DO IGUACU', 'PR', 'BRASIL'); ");
            migrationBuilder.Sql("INSERT INTO ENDERECOS VALUES(12,'ABRAO DIB', 'PARAISO', '656', '04004-060', 'CASA COM ARVORE', 'PRIMEIRA CASA DA RUA', 'SAO PAULO', 'SP', 'BRASIL'); ");
            migrationBuilder.Sql("INSERT INTO ENDERECOS VALUES(13,'VIRGULINO MAGALHAES', 'UNIVERSITARIO', '441', '29933-470', 'ULTIMO ANDAR', 'APTO 780', 'SAO MATEUS', 'ES', 'BRASIL'); ");
            migrationBuilder.Sql("INSERT INTO ENDERECOS VALUES(14,'FRANCISCO TENORIO ARAUJO', 'TRAPICHE DA BARRA', '992', '57010-772', 'TERREO', 'CASA COM MURO AZUL', 'MACEIO', 'AL', 'BRASIL'); ");
            migrationBuilder.Sql("INSERT INTO ENDERECOS VALUES(15,'TRAVESSA OTACILIO OLIVEIRA', 'INDUSTRIAL', '600', '49065-093', 'PRIMEIRO ANDAR', 'APTO 115', 'ARACAJU', 'SE', 'BRASIL'); ");
            migrationBuilder.Sql("INSERT INTO ENDERECOS VALUES(16,'ANA AMALIA', 'ALTINO BARBOSA', '947', '39800-060', 'ULTIMO ANDAR', 'AZULEJO ROSA', 'TEOFILO OTONI', 'MG', 'BRASIL'); ");
            migrationBuilder.Sql("INSERT INTO ENDERECOS VALUES(17,'QUADRA 203 NORTE ALAMEDA 3', 'PLANO DIRETOR NORTE', '958', '77006-898', 'ULTIMO ANDAR', 'APTO 712', 'PALMAS', 'TO', 'BRASIL'); ");
            migrationBuilder.Sql("INSERT INTO ENDERECOS VALUES(18,'PORTO DE SANTANA', 'POTENGI', '349', '59127-620', 'CASA ROSA', 'AO LADO DA LOJA BABALU', 'NATAL', 'RN', 'BRASIL'); ");
            migrationBuilder.Sql("INSERT INTO ENDERECOS VALUES(19,'IARA PIRONDI', 'CAMPO GRANDE', '543', '23016-650', 'TERCEIRA CASA DA RUA', 'PORTAO DE FERRO PRETO', 'RIO DE JANEIRO', 'RJ', 'BRASIL'); ");
            migrationBuilder.Sql("INSERT INTO ENDERECOS VALUES(20,'AVENIDA ABACATAL', 'BRASIL NOVO', '877', '68909-301', 'QUINTO ANDAR', 'APTO 500', 'MACAPA', 'AP', 'BRASIL'); ");

            migrationBuilder.Sql("INSERT INTO CLIENTES VALUES(1,'JAMILE DAMASCENO BRANDAO','1995-06-22','099.016.041-61','99134-3899','JAMJAM@GMAIL.COM','123456SJ$$',1);");
            migrationBuilder.Sql("INSERT INTO CLIENTES VALUES(2,'RODRIGO ARAUJO SANTOS','2002-02-13','123.011.432-66','99935-0890','DIGODIGO@GMAIL.COM','87845454SS$',2);");
            migrationBuilder.Sql("INSERT INTO CLIENTES VALUES(3,'PAMELA BABARA LISBOA','1987-05-10','155.022.99-36','98875-0369','PAMPAM@GMAIL.COM','878784541XX&',3);");
            migrationBuilder.Sql("INSERT INTO CLIENTES VALUES(4,'CLARINE LUANA BETINA','1976-09-09','651.561.884-00','99867-7999','CLARICEBET@GMAIL.COM','9522SDA541X6*',4);");
            migrationBuilder.Sql("INSERT INTO CLIENTES VALUES(5,'LUAN CAUE DA MOTA','1942-10-02','407.131.010-32','99335-6113','LUAN_MOTA@GMAIL.COM','9263612HJG#',5);");
            migrationBuilder.Sql("INSERT INTO CLIENTES VALUES(6,'SILEZIA MEYER LEONICIO','1950-07-29','154.023.370-71','99225-1184','SILEZIAMEYER@GMAIL.COM','#7776292JS!',6);");
            migrationBuilder.Sql("INSERT INTO CLIENTES VALUES(7,'LUCIMBERTO CONCEICAO LEONICIO','1959-02-15','648.936.770-04','98249-5676','LUCIMBERTO_LEO@GMAIL.COM','UYEUYW627!',7);");
            migrationBuilder.Sql("INSERT INTO CLIENTES VALUES(8,'IZABEL BATISTA MEYER','1985-08-28','826.413.360-65','99199-3646','IZABELM_@GMAIL.COM','JG#651376512',8);");
            migrationBuilder.Sql("INSERT INTO CLIENTES VALUES(9,'MARIZA DA PAIXAO MATEUS','1999-11-03','492.245.200-14','98222-9876','M_PAIXAO@GMAIL.COM','@HSDUA287G46',9);");
            migrationBuilder.Sql("INSERT INTO CLIENTES VALUES(10,'ROSANE DUTRA TEREZINA','1994-08-05','249.560.980-57','99868-5118','DUTRA_DUTRA@GMAIL.COM','398715$$1#',10);");
            migrationBuilder.Sql("INSERT INTO CLIENTES VALUES(11,'CARLOS LUIS FIGUEIRO MONTILLA','1998-10-30','336.914.610-00','99287-3333','CARLOS_GATO@GMAIL.COM','7987514$TTR#',11);");
            migrationBuilder.Sql("INSERT INTO CLIENTES VALUES(12,'JUZELINA ARAUJO SANTOS','1991-03-28','476.292.580-20','99854-9336','JUZELINA@GMAIL.COM','%787544HHFG',12);");
            migrationBuilder.Sql("INSERT INTO CLIENTES VALUES(13,'MARINA JALES SOUZA','1962-07-21','932.301.210-66','99648-8136','JALES_JALES@GMAIL.COM','4A8SD7AS8**F',13);");
            migrationBuilder.Sql("INSERT INTO CLIENTES VALUES(14,'ARLETE BOELHO LUQUES','1999-10-06','297.255.690-91','99033-8797','BOELHOARLETE@GMAIL.COM','987874445!HBG',14);");
            migrationBuilder.Sql("INSERT INTO CLIENTES VALUES(15,'SANDRO LEONICIO CAMARA','1940-04-21','702.543.080-31','99634-6478','LEONICIO_CAMARA@GMAIL.COM','$$SDFSD3234',15);");
            migrationBuilder.Sql("INSERT INTO CLIENTES VALUES(16,'LILIANE MARINS GONCALVES','1963-07-31','030.155.700-48','99456-6998','MARINS_LILIANE@GMAIL.COM','R8E7WR8W%%1',16);");
            migrationBuilder.Sql("INSERT INTO CLIENTES VALUES(17,'FERNANDA BEATRIZ TEIXEIRA LANA','1993-12-24','851.838.850-36','98745-3366','BEATRIZ_FERNANDA@GMAIL.COM','79879**HGFDS',17);");
            migrationBuilder.Sql("INSERT INTO CLIENTES VALUES(18,'BENTO SALES BARROS','1978-03-24','620.036.970-47','99787-1212','BENTOSALES@GMAIL.COM','898787&ADS',18);");
            migrationBuilder.Sql("INSERT INTO CLIENTES VALUES(19,'MICHEL DE ARRUDA CARINO','1998-11-11','136.530.150-81','99866-7788','MICHELCARINO@GMAIL.COM','!!@ASDATYT632',19);");
            migrationBuilder.Sql("INSERT INTO CLIENTES VALUES(20,'ELIEZER ANTUNES FACRE','1975-01-02','097.637.700-41','99788-3567','ELIEZERANTUNES@GMAIL.COM','1111HGY351!',20);");

            migrationBuilder.Sql("INSERT INTO PRODUTOS VALUES(1,'CIMENTO',32.50);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS VALUES(2,'ARGAMASSA',50.00);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS VALUES(3,'VERGALHAO',60.00);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS VALUES(4,'TUBO',25.00);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS VALUES(5,'TRELICA',66.00);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS VALUES(6,'IMPERMEABILIZANTE',170);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS VALUES(7,'MADEIRA',80);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS VALUES(8,'CAL',15);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS VALUES(9,'ACO',10);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS VALUES(10,'GESSO',20);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS VALUES(11,'PISO', 82);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS VALUES(12,'ROLO DE FIO', 60);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS VALUES(13,'TRENA', 10.23);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS VALUES(14,'ALICATE DE CORTE', 17.40);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS VALUES(15,'VIGA', 45);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS VALUES(16,'CAIXA DE LUZ', 1.49);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS VALUES(17,'QUADRO DE DISTRIBUICAO', 99.50);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS VALUES(18,'LATA DE TINTA', 198.9);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS VALUES(19,'GRAUTE', 54);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS VALUES(20,'SACO DE PREGO', 67.55);");

            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(1,'2022-09-01',1);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(2,'2022-08-01',2);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(3,'2022-07-01',3);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(4,'2022-08-03',4);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(5,'2022-07-03',5);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(6,'2022-08-03',6);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(7,'2022-06-04',9);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(8,'2022-07-05',10);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(9,'2022-09-06',11);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(10,'2022-09-07',15);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(11,'2022-09-08',14);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(12,'2022-09-09',1);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(13,'2022-07-10',9);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(14,'2022-06-09',9);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(15,'2022-06-10',16);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(16,'2022-06-11',17);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(17,'2022-09-20',18);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(18,'2022-08-18',19);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(19,'2022-06-17',6);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(20,'2022-07-17',3);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(21,'2022-09-15',11);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(22,'2022-09-13',13);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(23,'2022-09-14',20);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(24,'2022-08-30',2);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(25,'2022-08-10',5);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(26,'2022-08-09',18);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(27,'2022-07-15',12);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS VALUES(28,'2022-07-17',1);");

            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(1,1,1,22);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(2,1,3,9);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(3,1,11,15);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(4,2,2,10);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(5,2,7,10);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(6,2,9,1);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(7,2,13,13);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(8,2,17,3);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(9,3,5,17);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(10,3,1,13);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(11,3,11,14);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(12,3,20,2);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(13,4,20,25);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(14,4,12,35);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(15,5,5,4);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(16,6,6,3);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(17,6,8,10);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(18,6,10,16);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(19,6,11,18);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(20,6,14,25);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(21,6,16,30);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(22,6,3,36);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(23,6,7,22);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(24,7,1,70);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(25,7,9,50);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(26,7,15,100);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(27,8,1,33);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(28,8,9,44);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(29,8,11,2);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(30,8,15,3);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(31,8,20,17);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(32,9,9,7);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(33,10,11,4);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(34,10,19,6);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(35,10,17,13);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(36,10,15,30);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(37,11,11,40);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(38,11,19,3);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(39,12,6,70);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(40,12,7,95);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(41,12,9,100);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(42,13,11,45);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(43,13,17,50);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(44,14,11,2);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(45,14,10,22);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(46,14,9,25);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(47,14,3,25);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(48,14,6,23);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(49,14,4,22);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(50,14,1,21);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(51,14,6,20);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(52,15,7,9);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(53,16,9,2);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(54,16,6,43);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(55,17,2,1);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(56,17,11,10);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(57,17,13,11);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(58,17,15,21);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(59,18,18,9);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(60,19,19,25);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(61,19,3,75);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(62,20,18,8);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(63,20,17,9);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(64,20,13,13);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(65,20,9,15);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(66,20,7,19);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(67,20,1,33);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(68,21,3,22);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(69,21,9,50);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(70,21,7,44);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(71,22,2,6);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(72,23,3,13);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(73,24,4,22);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(74,25,5,23);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(75,25,10,30);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(76,26,6,100);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(77,27,7,7);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(78,27,9,3);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(79,27,20,1);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(80,27,19,5);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(81,27,18,13);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(82,27,13,19);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(83,27,3,65);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(84,27,4,33);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(85,27,1,10);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(86,27,16,15);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(87,28,2,69);");
            migrationBuilder.Sql("INSERT INTO PEDIDOS_PRODUTOS VALUES(88,28,10,100);");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
