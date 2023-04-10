namespace MapsterMappingExample.Models
{
    public class GameCharacter
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public Location? Location { get; set; }
    }
}
