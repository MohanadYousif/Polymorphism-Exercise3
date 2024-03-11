
namespace PolymorphismExercise.Errors
{
    // 3. Skapa en vanlig klass NumericInputError som ärver från UserError
    internal class FileReadError : UserError
    {
        public override string UEMessage()
        {
            return "Error reading file. Make sure the file exists and try again.";
        }
    }
}
