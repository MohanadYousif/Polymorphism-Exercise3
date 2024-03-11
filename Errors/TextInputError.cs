
namespace PolymorphismExercise.Errors
{
    // 9. Skapa egen klass FileReadError som ärver från UserError
    internal class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }
}
