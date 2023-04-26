namespace CRMS.Services._BackgroundServices.Token
{
    public interface ITokenStorage
    {
        Tokens RetrieveContactToken();
        Tokens RetrieveProductToken();
        void StoreContactToken(Tokens token);
        void StoreProdcutToken(Tokens token);
    }
}
