﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoordGrab.Properties {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CoordGrab.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;ArrayOfTrueCoord xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot; xmlns:xsd=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///  &lt;TrueCoord&gt;
        ///    &lt;X&gt;
        ///      &lt;_data&gt;
        ///        &lt;DoubleInterpDouble&gt;
        ///          &lt;double&gt;0&lt;/double&gt;
        ///          &lt;InterpDouble Value=&quot;4.019292604501608&quot; /&gt;
        ///        &lt;/DoubleInterpDouble&gt;
        ///        &lt;DoubleInterpDouble&gt;
        ///          &lt;double&gt;0.5&lt;/double&gt;
        ///          &lt;InterpDouble Value=&quot;6.109324758842444&quot; /&gt;
        ///        &lt;/DoubleInterpDouble&gt;
        ///        &lt;DoubleInterpD [остаток строки не уместился]&quot;;.
        /// </summary>
        internal static string Coords {
            get {
                return ResourceManager.GetString("Coords", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap PauseImage {
            get {
                object obj = ResourceManager.GetObject("PauseImage", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap PlayImage {
            get {
                object obj = ResourceManager.GetObject("PlayImage", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;ArrayOfFuzzySignal xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot; xmlns:xsd=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///  &lt;FuzzySignal&gt;
        ///    &lt;OneHzImpulse&gt;
        ///      &lt;_data&gt;
        ///        &lt;DoubleInterpDouble&gt;
        ///          &lt;double&gt;0&lt;/double&gt;
        ///          &lt;InterpDouble Value=&quot;1&quot; /&gt;
        ///        &lt;/DoubleInterpDouble&gt;
        ///        &lt;DoubleInterpDouble&gt;
        ///          &lt;double&gt;0.7&lt;/double&gt;
        ///          &lt;InterpDouble Value=&quot;0&quot; /&gt;
        ///        &lt;/DoubleInterpDouble&gt;
        ///        &lt;DoubleInterpDouble&gt;
        ///          [остаток строки не уместился]&quot;;.
        /// </summary>
        internal static string Signals {
            get {
                return ResourceManager.GetString("Signals", resourceCulture);
            }
        }
    }
}
