
namespace PolymorphismExercise.Errors
{
    // 3. Skapa en vanlig klass NumericInputError som ärver från UserError
    internal class NumericInputError : UserError
    {
        // 4. Skriv en override för UEMessage() så att den returerar “You tried to use a
        // numeric input in a text only field. This fired an error!”
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }
}
