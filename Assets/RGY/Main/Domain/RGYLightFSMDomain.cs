using UnityEngine;

namespace RGY {

    public class RGYLightFSMDomain {

        RGYContext context;

        public RGYLightFSMDomain() { }

        public void Inject(RGYContext context) {
            this.context = context;
        }

        public void ApplyRGY(RGYLightEntity entity) {
            var fsm = entity.FSM;
            var status = fsm.Status;
            switch (status) {
                case RGYLightStatus.Red:
                    ApplyRed(entity);
                    break;
                case RGYLightStatus.Yellow:
                    ApplyYellow(entity);
                    break;
                case RGYLightStatus.Green:
                    ApplyGreen(entity);
                    break;
            }
        }

        void ApplyRed(RGYLightEntity entity) {

            var fsm = entity.FSM;
            var stateModel = fsm.RedStateModel;
            if (stateModel.isEnter) {
                stateModel.isEnter = false;
                Debug.Log("Enter Red");
                return;
            }

            stateModel.timeSec += Time.deltaTime;
            if (stateModel.timeSec >= stateModel.maitainTimeSec) {
                fsm.SetEnterYellowParam();
            }

        }

        void ApplyYellow(RGYLightEntity entity) {

            var fsm = entity.FSM;
            var stateModel = fsm.YellowStateModel;
            if (stateModel.isEnter) {
                stateModel.isEnter = false;
                Debug.Log("Enter Yellow");
                return;
            }

            stateModel.timeSec += Time.deltaTime;
            if (stateModel.timeSec >= stateModel.maitainTimeSec) {
                fsm.SetEnterGreenParam();
            }

        }

        void ApplyGreen(RGYLightEntity entity) {

            var fsm = entity.FSM;
            var stateModel = fsm.GreenStateModel;
            if (stateModel.isEnter) {
                stateModel.isEnter = false;
                Debug.Log("Enter Green");
                return;
            }

            stateModel.timeSec += Time.deltaTime;
            if (stateModel.timeSec >= stateModel.maitainTimeSec) {
                fsm.SetEnterRedParam();
            }
        }

    }

}