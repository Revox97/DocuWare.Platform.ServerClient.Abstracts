namespace DocuWare.Platform.ServerClient.Abstracts
{
    public enum StepTypeEnum
    {
		DecisionHistoryStep = 0,
		GeneralErrorDecisionHistoryStep = 1,
		ReassignHistoryStep = 2,
		AssignDataHistoryStep = 3,
		AssignToHistoryStep = 4,
		ConditionHistoryStep = 5,
		EmailHistoryStep = 6,
		WebServiceHistoryStep = 7,
		StartHistoryStep = 8,
		TaskInProgressHistoryStep = 9,
		StopHistoryStep = 10,
		EndHistoryStep = 11,
		ErrorHistoryStep = 12,
		TimeoutHistoryStep = 13,
		OutOfOfficeHistotyStep = 14,
		RequestDecisionHistoryStep = 15,
		RequestStartHistoryStep = 16,
		RequestInProgressHistoryStep = 17,
		RequestEndHistoryStep = 18,
		WaitHistoryStep = 19,
		EventHistoryStep = 20,
		MultipleConditionHistorySteps = 21,
		RestartWorkflowHistoryStep = 22
    }
}
