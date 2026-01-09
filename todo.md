**Missing implementation**
- [ ] documentation comments
- [x] Handle of generic methods e.g GetXml<T>()
- [ ] Handle of extension methods
- [ ] Handle of abstract types (WebFormControl)
- [x] Handle ToString overloads correctly
- [x] Handle inheritance by according interface structure

**Open Issues**
- [x] ServiceConnection + IServiceConnection
    - [x] GetOrganizationsAsync() needs conversion to correct array
    - [x] GetXml uses generic types, which need handling
    - [x] GetXmlAsync uses generic types, which need handling
- [ ] FormInfo + IFormInfo + WebFromControls + IWebFormControls
    - [ ] WebFormControl is abstract and needs special treatment
- [x] Double nested docuware type lists
