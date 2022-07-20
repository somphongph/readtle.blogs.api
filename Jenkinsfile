pipeline {
  agent any
  stages {
    stage('Clean workspace') {
      steps {
        cleanWs()
      }
    }
    stage ('Git Checkout') {
    steps {
        git branch: 'main', 
        credentialsId: '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', 
        url: 'https://github.com/somphongph/readtle.blogs.api.git'
      }
    }

  }
}