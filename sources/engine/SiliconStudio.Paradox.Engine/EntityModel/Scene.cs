// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using SiliconStudio.Core;
using SiliconStudio.Core.Serialization.Contents;
using SiliconStudio.Paradox.Engine;

namespace SiliconStudio.Paradox.EntityModel
{
    /// <summary>
    /// A scene.
    /// </summary>
    [DataContract("Scene")]
    [ContentSerializer(typeof(DataContentSerializerWithReuse<Scene>))]
    public sealed class Scene : Entity
    {
        private SceneComponent settings;

        static Scene()
        {
            PropertyContainer.AddAccessorProperty(typeof(Scene), SceneComponent.Key);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Scene"/> class.
        /// </summary>
        public Scene()
        {
            // By default a scene always have a SceneComponent
            Settings = new SceneComponent();
        }

        /// <summary>
        /// Gets the settings of this scene.
        /// </summary>
        /// <value>The settings.</value>
        [DataMemberIgnore]
        public SceneComponent Settings
        {
            get { return settings; }
            internal set
            {
                var settingsOld = settings;
                settings = value;
                Components.RaisePropertyContainerUpdated(SceneComponent.Key, settings, settingsOld);
            }
        }

        protected override void Destroy()
        {
            Settings.Dispose();

            base.Destroy();
        }
    }
}
