namespace ApiDesafioMicroservicosProduto.Exceptions
{
    [Serializable]
    public class RequisicaoInvalidaException : Exception
    {
        public RequisicaoInvalidaException()
        {
        }

        public RequisicaoInvalidaException(string? message) : base(message)
        {
        }
    }
}
