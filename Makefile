test-watch:
	dotnet watch test --project Calculator.Tests --logger:"console;verbosity=detailed"
.PHONY: test-watch