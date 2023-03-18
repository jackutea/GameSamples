namespace RGY {

    public class RGYContext {

        RGYLightRepo repo;
        public RGYLightRepo Repo => repo;

        public RGYContext() {
            repo = new RGYLightRepo();
        }

    }
}