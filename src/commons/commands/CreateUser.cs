namespace commons.commands
{
    public class CreateUser : ICommand
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }   

    }
}