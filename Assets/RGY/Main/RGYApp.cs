using UnityEngine;

namespace RGY {

    // 控制逻辑
    public class RGYApp : MonoBehaviour {

        RGYContext context;
        RGYFactory factory;

        RGYLightFSMDomain lightFSMDomain;
        RGYLightDomain lightDomain;

        void Awake() {

            // Instantiate
            context = new RGYContext();
            factory = new RGYFactory();

            lightFSMDomain = new RGYLightFSMDomain();
            lightDomain = new RGYLightDomain();

            // Injection
            lightFSMDomain.Inject(context);
            lightDomain.Inject(context, factory);

            // Init
            lightDomain.SpawnUnique();

        }

        void Update() {
            // 找到要处理的实体
            // 控制逻辑
            var currentRGY = context.Repo.Current;
            lightFSMDomain.ApplyRGY(currentRGY);
        }

    }

}