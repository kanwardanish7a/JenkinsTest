pipeline {
    agent any

    environment {
        DOTNET_VERSION = '8.0' // Replace with your .NET version (e.g., 6.0, 7.0, etc.)
        PROJECT_PATH = 'JenkinsTest\\ToDoApi\\ToDoApi\\ToDoApi.csproj' // Windows-style path to your .csproj file
        OUTPUT_DIR = 'C:\\JenkinsOutput\\TodoApp' // Windows-style output directory
    }

    stages {
        stage('Restore') {
            steps {
                echo 'Restoring dependencies...'
                bat 'dotnet restore %PROJECT_PATH%' // Use %PROJECT_PATH% for Windows
            }
        }

        stage('Build') {
            steps {
                echo 'Building the application...'
                bat 'dotnet build %PROJECT_PATH% --configuration Release --no-restore'
            }
        }

        stage('Test') {
            steps {
                echo 'Running unit tests...'
                bat 'dotnet test %PROJECT_PATH% --configuration Release --no-build'
            }
        }

        stage('Publish') {
            steps {
                echo 'Publishing the application...'
                bat 'dotnet publish %PROJECT_PATH% --configuration Release --output %OUTPUT_DIR% --no-build'
            }
        }

        stage('Deploy') {
            steps {
                echo 'Deploying the application...'
                // Example: Copy files to another directory (for practice)
                bat 'xcopy %OUTPUT_DIR% C:\\DeployedApps\\TodoApp /E /I'
            }
        }
    }

    post {
        success {
            echo 'Pipeline succeeded! The Todo application has been deployed.'
        }
        failure {
            echo 'Pipeline failed! Check the logs for errors.'
        }
    }
}
