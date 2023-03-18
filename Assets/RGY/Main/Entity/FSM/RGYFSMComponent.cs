namespace RGY {

    public class RGYFSMComponent {

        RGYLightStatus status;
        public RGYLightStatus Status => status;

        RGYLightRedStateModel redStateModel;
        public RGYLightRedStateModel RedStateModel => redStateModel;

        RGYLightYellowStateModel yellowStateModel;
        public RGYLightYellowStateModel YellowStateModel => yellowStateModel;

        RGYLightGreenStateModel greenStateModel;
        public RGYLightGreenStateModel GreenStateModel => greenStateModel;

        public RGYFSMComponent() {
            redStateModel = new RGYLightRedStateModel();
            yellowStateModel = new RGYLightYellowStateModel();
            greenStateModel = new RGYLightGreenStateModel();
        }

        public void SetEnterRedParam() {
            status = RGYLightStatus.Red;
            redStateModel.isEnter = true;
            redStateModel.maitainTimeSec = 1f;
            redStateModel.timeSec = 0f;
        }

        public void SetEnterYellowParam() {
            status = RGYLightStatus.Yellow;
            yellowStateModel.isEnter = true;
            yellowStateModel.maitainTimeSec = 1f;
            yellowStateModel.timeSec = 0f;
        }

        public void SetEnterGreenParam() {
            status = RGYLightStatus.Green;
            greenStateModel.isEnter = true;
            greenStateModel.maitainTimeSec = 1f;
            greenStateModel.timeSec = 0f;
        }

    }
}