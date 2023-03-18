namespace RGY {

    public class RGYLightDomain {

        RGYContext context;
        RGYFactory factory;

        public RGYLightDomain() {}

        public void Inject(RGYContext context, RGYFactory factory) {
            this.context = context;
            this.factory = factory;
        }

        public void SpawnUnique() {
            var entity = factory.CreateLightEntity();
            context.Repo.SetCurrent(entity);
        }

    }
}