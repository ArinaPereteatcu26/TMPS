namespace CreationalDesignPattern.Domain
{
    public abstract class CharacterEnhancement : Character
    {
        protected Character _character;
        public CharacterEnhancement(Character character)
        {
            _character = character;
        }

        public override void Attack()
        {
            _character.Attack();
        }
    }

    public class SkillEnhancement : CharacterEnhancement
    {
        public string Name { get; private set; }
        public string Skill { get; set; }

        public SkillEnhancement(Character character) : base(character)
        {

            Name = $"Skill has been added to {character.Name}";
        }

        public override void Attack()
        {
            Console.WriteLine($"Has new skill {Skill}");
            base.Attack();
        }
    }

}