using System.Collections.Generic;

namespace RGY {

    public class RGYLightRepo {

        RGYLightEntity current;
        public RGYLightEntity Current => current;
        public void SetCurrent(RGYLightEntity entity) {
            current = entity;
        }

        public RGYLightRepo() { }

    }

}