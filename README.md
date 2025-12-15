# Template Repository For Custom Unity Packages


# Github Actions

This template repository includes actions to help automate workflows. All actions are disabled by default and will not run unless you reenable them.

| Action | Description | Runs On |
| ------ | ------------- | ------------ |
| Unity Package Unit Tests | Runs Unit tests on configured assemblies when c# files are changed within the repository. | Pull Requests to the main branch |
| Update Changelog | Automatically updates the CHANGELOG.md file based on keywords in commits. Runs on every commit to the main branch. | Commits to the main branch |

If you'd like to change when these actions run, you can refer to the official action documentation [here](https://docs.github.com/en/actions/how-tos/write-workflows/choose-when-workflows-run/trigger-a-workflow)

## Using The Changlog Action

### How It Works

The entire commit history is pulled, keywords are searched for and commit messages appended to the CHANGELOG.md file accordingly using the [TriPSs/conventional-changelog-action@v5](https://github.com/TriPSs/conventional-changelog-action) action.

### How To Use

Include keywords in the commit message and then elaborate on changes in the description.
To read about the commit keywords refer to [Coventional Commits](https://www.conventionalcommits.org/en/v1.0.0/).
Keywords can be added, removed, or overwritten entirely if you please; check [here](https://github.com/TriPSs/conventional-changelog-action?tab=readme-ov-file#presets) to see how.

## Using the Unit Tests Action

### How It Works

The action uses [tj-actions/changed-files](https://github.com/tj-actions/changed-files) to check for changed c# files. 
If c# files have been changed, then a cache check will happen for the TempProject/Library folder. After that the
[game-ci/unity-test-runner](https://github.com/game-ci/unity-test-runner) will run and return an artifact with the test results.

### Required Secrets

| Secret | Description |
| ------ | ----------- |
| UNITY_EMAIL | The email account associated with your Unity profile |
| UNITY_PASSWORD | The password associated with your Unity profile |
| UNITY_LICENSE | The license to use to activate the Unity application. See [game.ci/docs](https://game.ci/docs/github/activation) for more info | 

These secrets are required for the Temperary Unity project to run and therefor be used to perform the unit tests.

# Additional Reading

https://docs.unity3d.com/6000.2/Documentation/Manual/CustomPackages.html
