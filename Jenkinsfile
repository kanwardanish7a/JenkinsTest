pipeline {
    agent any

    environment {
        DOTNET_VERSION = '8.0' // Replace with your .NET version (e.g., 6.0, 7.0, etc.)
        PROJECT_PATH = 'JenkinsTest/ToDoApi/ToDoApi/ToDoApi.csproj' // Path to your .csproj file
        OUTPUT_DIR = 'publish' // Directory to publish the application
    }

    stages {
        stage('Restore') {
            steps {
                echo 'Restoring dependencies...'
                sh 'dotnet restore ${PROJECT_PATH}'
            }
        }

        stage('Build') {
            steps {
                echo 'Building the application...'
                sh 'dotnet build ${PROJECT_PATH} --configuration Release --no-restore'
            }
        }

        stage('Test') {
            steps {
                echo 'Running unit tests...'
                sh 'dotnet test ${PROJECT_PATH} --configuration Release --no-build'
            }
        }

        stage('Publish') {
            steps {
                echo 'Publishing the application...'
                sh 'dotnet publish ${PROJECT_PATH} --configuration Release --output ${OUTPUT_DIR} --no-build'
            }
        }

        stage('Deploy') {
            steps {
                echo 'Deploying the application...'
                // Example: Deploy to a remote server using SCP
               
                // Alternatively, deploy to a Docker container, Azure, or other platforms
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
