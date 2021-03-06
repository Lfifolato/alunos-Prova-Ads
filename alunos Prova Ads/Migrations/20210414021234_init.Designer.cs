// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using alunos_Prova_Ads.Data;

namespace alunos_Prova_Ads.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210414021234_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("alunos_Prova_Ads.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("curso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idade")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomeFaculdade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            cpf = "66565656",
                            curso = "ADS",
                            idade = 22,
                            nome = "Luiz Henrique",
                            nomeFaculdade = "Reges"
                        },
                        new
                        {
                            Id = 2,
                            cpf = "65656565",
                            curso = "ADM",
                            idade = 28,
                            nome = "Andre",
                            nomeFaculdade = "UNIP"
                        },
                        new
                        {
                            Id = 3,
                            cpf = "87454545",
                            curso = "CUlinaria",
                            idade = 30,
                            nome = "Danilo",
                            nomeFaculdade = "Comida Boa"
                        },
                        new
                        {
                            Id = 4,
                            cpf = "61656565",
                            curso = "Power Bi",
                            idade = 22,
                            nome = "Pedro",
                            nomeFaculdade = "mais mais"
                        },
                        new
                        {
                            Id = 5,
                            cpf = "988989898",
                            curso = "Execel",
                            idade = 22,
                            nome = "Hariel",
                            nomeFaculdade = "data"
                        },
                        new
                        {
                            Id = 6,
                            cpf = "66565656",
                            curso = "Web",
                            idade = 22,
                            nome = "Tiago",
                            nomeFaculdade = "Reges"
                        },
                        new
                        {
                            Id = 7,
                            cpf = "66565656",
                            curso = "TESTE",
                            idade = 22,
                            nome = "Lucas",
                            nomeFaculdade = "Reges"
                        },
                        new
                        {
                            Id = 8,
                            cpf = "5457485787",
                            curso = "jS",
                            idade = 22,
                            nome = "Guilherme",
                            nomeFaculdade = "Reges"
                        },
                        new
                        {
                            Id = 9,
                            cpf = "66565656",
                            curso = "TESTE",
                            idade = 22,
                            nome = "Paulo",
                            nomeFaculdade = "ffff"
                        },
                        new
                        {
                            Id = 10,
                            cpf = "66565656",
                            curso = "ffff",
                            idade = 22,
                            nome = "Rafael",
                            nomeFaculdade = "Reges"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
