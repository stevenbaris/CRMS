namespace CRMS.Services._BackgroundServices.Token
{
    public class InMemoryTokenStorage:ITokenStorage
    {
        private Tokens _contactToken;
        private Tokens _producttoken;

        public InMemoryTokenStorage(Tokens contactToken, Tokens producttoken)
        {
            _contactToken = contactToken;
            _producttoken = producttoken;
        }

        public Tokens RetrieveContactToken()
        {
            return _contactToken;
        }

        public Tokens RetrieveProductToken()
        {
            return _producttoken;
        }

        public void StoreContactToken(Tokens token)
        {
            _contactToken = token;
        }

        public void StoreProdcutToken(Tokens token)
        {
            _producttoken= token;
        }
    }
}
