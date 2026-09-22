pipeline {
    agent any

    tools {
        dotnetsdk 'dotnet8'
    }

    stages {

        stage('Git Checkout') {
            steps {
                git branch: 'main',
                    url: 'https://github.com/suryaprakash-bandoju/2-Tier-DotNet-Project-Inventory-Management-App.git'
            }
        }

        stage('Restoring Dependancies') {
            steps {
                sh 'sotnet restore'
            }
        }

        stage('Building') {
            steps {
                sh 'dotnet build'
            }
        }
    }

}