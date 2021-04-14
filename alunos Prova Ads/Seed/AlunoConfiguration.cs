using alunos_Prova_Ads.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alunos_Prova_Ads.Seed
{
    public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.HasData
                (
                new Aluno
                {
                    Id = 1,
                    cpf= "66565656",
                    curso= "ADS",
                    idade= 22,
                    nome= "Luiz Henrique",
                    nomeFaculdade= "Reges"                  
                },
                new Aluno
                {
                    Id = 2,
                    cpf = "65656565",
                    curso = "ADM",
                    idade = 28,
                    nome = "Andre",
                    nomeFaculdade = "UNIP"
                },
                new Aluno
                {
                    Id = 3,
                    cpf = "87454545",
                    curso = "CUlinaria",
                    idade = 30,
                    nome = "Danilo",
                    nomeFaculdade = "Comida Boa"
                },
                new Aluno
                {
                    Id = 4,
                    cpf = "61656565",
                    curso = "Power Bi",
                    idade = 22,
                    nome = "Pedro",
                    nomeFaculdade = "mais mais"
                },
                new Aluno
                {
                    Id = 5,
                    cpf = "988989898",
                    curso = "Execel",
                    idade = 22,
                    nome = "Hariel",
                    nomeFaculdade = "data"
                },
                new Aluno
                {
                    Id = 6,
                    cpf = "66565656",
                    curso = "Web",
                    idade = 22,
                    nome = "Tiago",
                    nomeFaculdade = "Reges"
                },
                new Aluno
                {
                    Id = 7,
                    cpf = "66565656",
                    curso = "TESTE",
                    idade = 22,
                    nome = "Lucas",
                    nomeFaculdade = "Reges"
                },
                new Aluno
                {
                    Id = 8,
                    cpf = "5457485787",
                    curso = "jS",
                    idade = 22,
                    nome = "Guilherme",
                    nomeFaculdade = "Reges"
                },
                new Aluno
                {
                    Id = 9,
                    cpf = "66565656",
                    curso = "TESTE",
                    idade = 22,
                    nome = "Paulo",
                    nomeFaculdade = "ffff"
                },
                 new Aluno
                 {
                     Id = 10,
                     cpf = "66565656",
                     curso = "ffff",
                     idade = 22,
                     nome = "Rafael",
                     nomeFaculdade = "Reges"
                 }
                );
        }


    }
}
