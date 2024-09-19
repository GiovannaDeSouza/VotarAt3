using VotosPNO;

namespace VotarTest
{
    public class VotarPo
    {
        [Fact]
        public void NaoPode()
        {
            int idade = 11;
            string esperado = "N�o pode votar!";
            string obtido = Voto.Pode(idade);
            Assert.Equal(esperado, obtido);
        }

        [Fact]
        public void OpcionalJovem()
        {
            int idade = 16;
            string esperado = "Voto opcional!";
            string obtido = Voto.Pode(idade);
            Assert.Equal(esperado, obtido);
        }

        [Fact]
        public void Pode()
        {
            int idade = 18;
            string esperado = "Voto obrigat�rio!";
            string obtido = Voto.Pode(idade);
            Assert.Equal(esperado, obtido);
        }

        [Fact]
        public void OpcionalIdoso()
        {
            int idade = 79;
            string esperado = "Voto opcional!";
            string obtido = Voto.Pode(idade);
            Assert.Equal(esperado, obtido);
        }
    }
}