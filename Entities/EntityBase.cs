namespace EventbriteNET.Entities
{
    public class EntityBase
    {
        public EventbriteContext Context;

        public EntityBase(EventbriteContext context)
        {
            this.Context = context;
        }
    }
}
