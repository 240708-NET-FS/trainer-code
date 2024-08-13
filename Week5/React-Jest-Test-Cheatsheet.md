# React Jest Test setup Cheatsheet

## Add this to your tsconfig.json

  "compilerOptions": {
    "jsx": "react",
    "esModuleInterop": true
  }

## Add this to your package.json

### inside "scripts"

    "test": "jest"

### below "devdependencies"

"jest": {
    "testEnvironment": "jsdom",
    "transform": {
      "^.+\\.tsx?$": "ts-jest"
    },
    "moduleFileExtensions": [
      "ts",
      "tsx",
      "js"
    ]
  }
