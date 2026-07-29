---
name: Test Request
about: >
    Commits que adicionam novos testes, melhoram testes existentes ou corrigem testes com falha.
    Exemplo: adicionar testes unitários para um novo componente ou atualizar mocks para testes de integração.
title: '[test]:'
labels: ['test']
assignees: []
---
## Resumo

Adicionar os testes unitários ausentes para a lógica de login, logout e renovação de token no `AuthService`.

## Tarefas

- [ ] Testar login com credenciais válidas
- [ ] Testar login com credenciais inválidas
- [ ] Testar se o logout remove o token
- [ ] Testar o comportamento da renovação de token

## Meta de cobertura

Alcançar pelo menos 90% de cobertura para `auth/AuthService.ts`.