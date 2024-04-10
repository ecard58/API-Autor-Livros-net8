using Autor_Livros.Dtos.Vinculo;

namespace Autor_Livros.Dtos.Livro
{
    public class LivroCriacaoDto
    {
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
