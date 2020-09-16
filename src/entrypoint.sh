#!/bin/sh -l

cd /app

dotnet restore
dotnet build
dotnet run --project src/GithubActions.Notimpo.ConsoleApp -- \
    --mailgun-api-key "$MAILGUN_API_KEY" \
    --to "$TO" \
    --from "$FROM" \
    --subject "$SUBJECT" \
    --message "$MESSAGE" \
    --notify-type "$NOTIFY_TYPE"