# React Jest Test setup Cheatsheet

## Add this to your tsconfig.json

```json
  "compilerOptions": {
    "jsx": "react",
    "esModuleInterop": true
  }
```

## Add this to your package.json

### inside "scripts"
```json
    "test": "jest"
```
### below "devdependencies"

```json
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
```
