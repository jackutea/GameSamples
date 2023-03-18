namespace RGY {

    public class RGYLightEntity {

        // FSM
        RGYFSMComponent fsm;
        public RGYFSMComponent FSM => fsm;

        public RGYLightEntity() {
            fsm = new RGYFSMComponent();
        }
        
    }
}