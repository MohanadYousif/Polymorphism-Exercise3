
namespace PolymorphismExercise.Errors
{
    // 3. Skapa en vanlig klass NumericInputError som ärver från UserError
    internal class ConnectionError : UserError
    {
        public override string UEMessage()
        {
            return "Connection failed. Please check your internet connection and try again.";
        }
    }
}
