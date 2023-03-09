namespace Nomadicooer.Translator
{
     public interface ITranslator{
        ITranslateResponse Translate(string from, string to, params string[] querys) ;

    }
}
