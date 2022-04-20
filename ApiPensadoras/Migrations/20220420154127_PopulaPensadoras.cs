using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiPensadoras.Migrations
{
    public partial class PopulaPensadoras : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Pensadoras(Nome, Ocupacao, Nacionalidade, Descricao, DataDeNascimento, DataDeFalecimento) " +
                "Values('Ada Lovelace', 'Programadora/Matemática', 'Inglesa', 'Augusta Ada Byron King, Condessa de Lovelace, atualmente conhecida como Ada Lovelace, foi uma matemática e escritora inglesa. Hoje é reconhecida principalmente por ter escrito o primeiro algoritmo para ser processado por uma máquina, a máquina analítica de Charles Babbage.', " +
                "'1815-12-10','1852-11-27')");
            mb.Sql("Insert into Pensadoras(Nome, Ocupacao, Nacionalidade, Descricao, DataDeNascimento, DataDeFalecimento) " +
                "Values('Simone de Beauvoir', 'Filósofa/Escritora', 'Francesa', 'Simone Lucie-Ernestine-Marie Bertrand de Beauvoir, mais conhecida como Simone de Beauvoir, foi uma escritora, intelectual, filósofa existencialista, ativista política, feminista e teórica social francesa', " +
                "'1908-01-09','1987-04-14')");
            mb.Sql("Insert into Pensadoras(Nome, Ocupacao, Nacionalidade, Descricao, DataDeNascimento, DataDeFalecimento) " +
               "Values('Hilda Hilst', 'Escritora', 'Brasileira', 'Hilda de Almeida Prado Hilst, mais conhecida como Hilda Hilst, foi uma poeta, ficcionista, cronista e dramaturga brasileira. É considerada pela crítica especializada como uma das maiores escritoras em língua portuguesa do século XX.', " +
               "'1930-04-21','2004-02-04')");
            mb.Sql("Insert into Pensadoras(Nome, Ocupacao, Nacionalidade, Descricao, DataDeNascimento) " +
                "Values('Angela Davis', 'Professora', 'Estadunidense', 'Angela Yvonne Davis, é uma professora e filósofa socialista estadunidense que alcançou notoriedade mundial na década de 1970 como integrante do Partido Comunista dos Estados Unidos, dos Panteras Negras, por sua militância pelos direitos das mulheres e contra a discriminação social e racial nos Estados Unidos, referência entre os marxistas e por ser personagem de um dos mais polêmicos e famosos julgamentos criminais da recente história dos EUA.', " +
                "'1944-01-26')");
            mb.Sql("Insert into Pensadoras(Nome, Ocupacao, Nacionalidade, Descricao, DataDeNascimento) " +
                "Values('Linda Nochlin', 'Professora/Historiadora', 'Estadunidense', 'Linda Nochlin foi uma historiadora de arte americana, Professora Emérita da cátedra Lila Acheson Wallace de Arte Moderna no Instituto de Belas Artes da Universidade de Nova York, e escritora. Historiadora de arte feminista de destaque, tornou-se conhecida por seu artigo pioneiro de 1971 Why Have There Been No Great Women Artists? ( Por que não houve grandes mulheres artistas?).', " +
                "'1931-01-30')");
            mb.Sql("Insert into Pensadoras(Nome, Ocupacao, Nacionalidade, Descricao, DataDeNascimento) " +
                "Values('Djamila Ribeiro', 'Filosofa/Feminista Negra/Escritora', 'Brasileira', 'Djamila Taís Ribeiro dos Santos é uma filósofa, feminista negra, escritora e acadêmica brasileira. É pesquisadora e mestra em Filosofia Política pela Universidade Federal de São Paulo (Unifesp). Tornou-se conhecida no país por seu ativismo na Internet, atualmente é colunista do jornal Folha de S. Paulo.', " +
                "'1931-01-30')");
            mb.Sql("Insert into Pensadoras(Nome, Ocupacao, Nacionalidade, Descricao, DataDeNascimento) " +
                "Values('Chimamanda Ngozi Adichie', 'Escritora', 'Nigeriana', 'Chimamanda Ngozi Adichie é uma feminista e escritora nigeriana. Ela é reconhecida como uma das mais importantes jovens autoras anglófonas de sucesso, atraindo uma nova geração de leitores de literatura africana.', " +
                "'1977-07-15')");
            mb.Sql("Insert into Pensadoras(Nome, Ocupacao, Nacionalidade, Descricao, DataDeNascimento) " +
                "Values('Malala Yousafzai', 'Ativista', 'Paquistanesa', 'Malala Yousafzai é uma ativista paquistanesa. Foi a pessoa mais nova a ser laureada com um prémio Nobel. É conhecida principalmente pela defesa dos direitos humanos das mulheres e do acesso à educação na sua região natal do vale do Swat na província de Khyber Pakhtunkhwa, no nordeste do Paquistão, onde os talibãs locais impedem as jovens de frequentar a escola. Desde então, o ativismo de Malala tornou-se um movimento internacional.', " +
                "'1997-07-12')");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Pensadoras");
        }
    }
}

