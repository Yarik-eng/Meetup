namespace Core.DTOs
{
    public class UpdateUserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}

// P.S юзаю DTOs для передачі даних між шарами щоб не використовувати сутності напряму