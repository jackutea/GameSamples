namespace RGY {

    public class RGYFactory {

        // Infrastructure
        //  Assets (.prefab)
        //  TemplateModel (.excel / ScriptableObject)

        public RGYFactory() {}

        public RGYLightEntity CreateLightEntity() {
            return new RGYLightEntity();
        }

    }
}