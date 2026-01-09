**Missing implementation**
- documentation comments
- Handling of generic methods e.g GetXml<T>()
- Handling of extension methods
- Handling of abstract types (WebFormControl)
- Handle ToString overloads correctly

**Open Issues**
- [ ] ServiceConnection + IServiceConnection
    - [ ] GetOrganizationsAsync() needs conversion to correct array
    - [ ] GetXml uses generic types, which need handling
    - [ ] GetXmlAsync uses generic types, which need handling
- [ ] FormInfo + IFormInfo + WebFromControls + IWebFormControls
    - [ ] WebFormControl is abstract and needs special treatment
