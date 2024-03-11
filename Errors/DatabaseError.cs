
namespace PolymorphismExercise.Errors
{
    // 9. Skapa egen klass DatabaseError som ärver från UserError
     internal class DatabaseError : UserError
    {
        public override string UEMessage()
        {
            return "Database connection failed. Please contact your system administrator.";
        }
    }
}
