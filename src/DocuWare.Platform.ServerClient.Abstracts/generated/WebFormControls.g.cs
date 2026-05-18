using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WebFormControls(SDK.WebFormControls obj) : IWebFormControls
    {
        internal SDK.WebFormControls Obj { get; } = obj;

        public List<IWebFormControl> WebFormControl
        {
            get
            {
                List<IWebFormControl> fields = [];

                foreach(SDK.WebFormControl formField in Obj.WebFormControl)
                {
                    Type type = formField.GetType();
                    fields.Add(type.GetConstructor(BindingFlags.Public, [typeof(SDK.WebFormControl)]).Invoke([formField]) as IWebFormControl);
                }

                return fields;
            }
            set
            {
                List<SDK.WebFormControl> fields = [];

                foreach(WebFormControl formField in value)
                {
                    Type type = formField.GetType();

                    PropertyInfo objPropertyInfo = type.GetProperty("Obj");
                    SDK.WebFormControl obj = objPropertyInfo.GetValue(formField) as SDK.WebFormControl;

                    fields.Add(obj);
                }

                Obj.WebFormControl = fields;
            }
        }
    }
}
